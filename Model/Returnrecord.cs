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
        public int Pat_Id { get; set; } //  病人外键 关联病人表
        public string Rer_Remake { get; set; } //   回访情况记录
        public string Rer_Time { get; set; } // 回访时间
    }
}
