using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Utils
{
    public static class Configuration
    {

        public static string GetDBConfiguration()
        {
            return "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CoreDB;Data Source=DELL";
        }
    }
}
