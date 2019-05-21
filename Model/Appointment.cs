using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Appointment
    {
        public int App_Id { get; set; }
        public int PatLog_Id { get; set; }
        public string App_Date { get; set; }
        public string App_Time { get; set; }
        public int App_Administrative { get; set; }
        public int App_Doctor { get; set; }
        public string App_Remark { get; set; }
        
    }
}
