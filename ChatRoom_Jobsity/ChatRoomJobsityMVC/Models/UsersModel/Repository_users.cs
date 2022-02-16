using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomJobsityMVC.Models.UsersModel
{
    public class Repository_users
    {
        public List<Users> UserList()
        {
            var users = new List<Users>
            {
                new Users{
                    id= 1,
                    username = "Nacho",
                    password = "Jobsity"
                },
                new Users{
                    id= 2,
                    username = "Jobsity",
                    password = "Jobsity"
                },
                new Users{
                    id= 3,
                    username = "Antonella",
                    password = "Jobsity"
                },
                new Users{
                    id= 4,
                    username = "Sebastian",
                    password = "Jobsity"
                },
                new Users{
                    id= 5,
                    username = "Admin",
                    password = "Jobsity"
                },
                new Users{
                    id= 6,
                    username = "admin",
                    password = "Jobsity"
                },
            };
            return users;
        }
    }
}
