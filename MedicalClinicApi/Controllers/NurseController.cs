using System;
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
        public List<Patient> PatientShow(string Pat_phone)
        {
            return bll.PatientShow(Pat_phone);
        }
        /// <summary>
        /// 病人信息添加
        /// </summary>
        /// <param name="pa"></param>
        /// <returns></returns>
        [HttpPost]
        public int PatientAdd(Patient pa)
        {
            return bll.PatientAdd(pa);
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
    }
}
