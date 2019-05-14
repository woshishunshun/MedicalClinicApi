using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Doctor
    {
        public int Doc_Id { get; set; } //  医生表Id
        public int Adm_Id { get; set; } //  医生所属科室
        public string Doc_Name { get; set; } // 医生姓名
        public int Doc_Age { get; set; } // 医生年龄
        public string Doc_Sex { get; set; } // 医生性别
        public string Doc_Time { get; set; } //  入职时间
        public int Doc_Type { get; set; } // 医生状态

    }
}
