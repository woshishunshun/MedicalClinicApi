﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;

namespace MedicalClinicApi.Controllers
{
    public class NurseController : ApiController
    {
        NurseBll bll = new NurseBll();
        /// <summary>
        /// 病人查询
        /// </summary>
        /// <param name="Pat_phone"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Patient> PatientShow(string phone)
        {
            return bll.PatientShow(phone);
        }
        /// <summary>
        /// 挂号
        /// </summary>
        /// <param name="re"></param>
        /// <returns></returns>
        [HttpPost]
        public int PatientLoginAdd(Registration re)
        {
            return bll.PatientLoginAdd(re);
        }
        /// <summary>
        /// 护士账号登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpGet]
        public int NurseLogin(string name, string pwd)
        {
            return bll.NurseLogin(name, pwd);
        }
        /// <summary>
        /// 反填科室表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Administrative> AdministrativeShow()
        {
            return bll.AdministrativeShow();
        }
        /// <summary>
        /// 二级联动医生表
        /// </summary>
        /// <param name="admId"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Doctor> DoctorShow(int admId)
        {
            return bll.DoctorShow(admId);
        }
    }
}
