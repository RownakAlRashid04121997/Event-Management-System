using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_project
{
    class UserClass
    {
        static string Username;

            public static string UserName{
                get {return Username;}
                set { Username = value; }
            }
    }
}
