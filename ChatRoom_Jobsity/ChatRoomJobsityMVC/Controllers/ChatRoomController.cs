using ChatRoomJobsityMVC.Models.CSVDataModel;
using CsvHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ChatRoomJobsityMVC.Controllers
{
    public class ChatRoomController : Controller
    {
        const string SessionName = "_Name";
        public IActionResult Index()
        {
            string user = HttpContext.Session.GetString(SessionName);
            if (user != null)
            {
                ViewBag.User = user;
                return View();
            }
            else
            {
                return Redirect("/Login/Index");
            }
        }

        [HttpPost]
        public JsonResult ReadCSVFromURL(string dataStock)
        {
            if (dataStock != null)
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create($"https://stooq.com/q/l/?s={dataStock}&f=sd2t2ohlcv&h&e=csv");
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(resp.GetResponseStream());
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<ModelClassMap>();
                    var records = csv.GetRecords<ModelCSV>();
                    ModelCSV[] array = records.Cast<ModelCSV>().ToArray();
                    var objJson = new
                    {
                        statusCode = 200,
                        statusMsg = "OK",
                        statusBool = true,
                        resultData = array
                    };
                    return Json(objJson);
                }
            }
            else
            {
                var objJson = new
                {
                    statusCode = 400,
                    statusMsg = "FAIL",
                    statusBool = false,
                    resultData = "Could you, please, specific the stock code?"

                };
                return Json(objJson);
            }

        }
    }
}
