using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patient
    {
        public int Pat_Id { get; set; } //病人表Id
        public int PatLog_Id { get; set; } // 外键 关联病人账号
        public string Pat_Name { get; set; }//病人姓名
        public string Pat_Sex { get; set; }//病人性别
        public int Pat_Age { get; set; }//病人年龄
        public string Pat_Sfz { get; set; }// 病人身份证
        public string Pat_Phone { get; set; }// 病人联系电话
    }
}
