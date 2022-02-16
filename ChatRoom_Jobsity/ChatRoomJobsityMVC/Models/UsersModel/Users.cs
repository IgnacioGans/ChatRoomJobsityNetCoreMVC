using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomJobsityMVC.Models.UsersModel
{
    public class Users
    {
        public int id { set; get; }
        public string username { set; get; }
        public string password { set; get; }

        public Users DataJsonToObject(string json)
        {
            Users dataDeposit = JsonConvert.DeserializeObject<Users>(json);
            return dataDeposit;
        }
    }
}
