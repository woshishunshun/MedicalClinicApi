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

    //Administrative科室表
    public class AdministrativeController : ApiController
    {
        AdministrativeBll bll = new AdministrativeBll();
        /// <summary>
        /// 查询科室表 用于绑定下拉列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Administrative> ShowAdministrative()
        {
            return bll.ShowAdministrative();
        }
        /// <summary>
        /// 查询医师表 绑定下拉
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Doctor> ShowDoctor(int id)
        {
            return bll.ShowDoctor(id);
        }
    }
}
