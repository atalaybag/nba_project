using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Login
{
    public class AppUser
    {
        public int AppUserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int AppRoleID { get; set; }
        public AppRole AppRole { get; set; }
        public AppUser()
        {
            AppRole = new AppRole();
        }


    }
}
