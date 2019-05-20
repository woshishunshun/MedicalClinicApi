using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Returnrecord
    {
        public int Rer_Id { get; set; } // 主键  回访记录表Id
        public int Reg_Id { get; set; } //  挂号Id
        public string Rer_Remake { get; set; } //   回访情况记录
        public string Rer_Time { get; set; } // 回访时间
        public int Doc_Id { get; set; }
        public string Doc_Name { get; set; }
        public string Pat_Name { get; set; }
        public string Reg_Time { get; set; }
    }
}
