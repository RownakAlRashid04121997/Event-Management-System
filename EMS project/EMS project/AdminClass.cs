using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_project
{
    class AdminClass:BaseClass
    {
        static string Adminname;

                public static string AdminName{
                get {return Adminname;}
                set { Adminname = value; }
            }
            
    }
}
