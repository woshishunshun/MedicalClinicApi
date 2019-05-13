﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Registration
    {
        public int Reg_Id { get; set; }//挂号表Id
        public int Pat_Id { get; set; }//关联病人信息表
        public string Reg_Time { get; set; }// 就诊时间
        public int Adm_Id { get; set; } //关联科室表
        public int Doc_Id { get; set; } //医生外键
        public int Reg_Type { get; set; } //  就诊状态

    }
}
