using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Doctorecord
    {
        public int Dcr_Id { get; set; }//就诊记录表Id
        public int Doc_Id { get; set; }//医生外键 关联医生表
        public int Adm_Id { get; set; }//科室外键 管理科室表
        public int Pat_Id { get; set; }//病人外键 关联病人外键
        public string Dcr_Remake { get; set; }// 诊断说明
        public string Dcr_Time { get; set; }//  结束就诊时间
        public string Dr_Name { get; set; }// 开的药品
        public int Reg_Id { get; set; }//挂号表Id
    }
}
