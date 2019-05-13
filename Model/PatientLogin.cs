using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PatientLogin
    {
        public int PatLog_Id { get; set; }
        public string PatLog_LogName { get; set; }
        public string PatLog_LogPwd { get; set; }
        public string PatLog_Time { get; set; }
    }
}
