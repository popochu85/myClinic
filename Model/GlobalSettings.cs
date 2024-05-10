using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myClinic.Model
{
    public static class GlobalSettings
    {
        public static string DatabaseConnectionString { get; set; }
        public static Employee employee { get; set; }
        public static Patient patient { get; set; }
    }
   
}
