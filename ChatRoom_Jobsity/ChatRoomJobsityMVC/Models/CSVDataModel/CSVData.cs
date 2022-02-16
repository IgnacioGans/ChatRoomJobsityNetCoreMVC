using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomJobsityMVC.Models.CSVDataModel
{
    public class CSVData
    {
        public string Symbol { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Open { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Close { get; set; }
        public string Volume { get; set; }
        
    }
    public class ModelCSV
    {
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public int Volume { get; set; }
    }

    public class ModelClassMap : ClassMap<ModelCSV>
    {
        public ModelClassMap()
        {
            Map(m => m.Symbol).Name("Symbol");
            Map(m => m.Date).Name("Date");
            Map(m => m.Time).Name("Time");
            Map(m => m.Open).Name("Open");
            Map(m => m.High).Name("High");
            Map(m => m.Low).Name("Low");
            Map(m => m.Close).Name("Close");
            Map(m => m.Volume).Name("Volume");
        }
    }


}
