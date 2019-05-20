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
    public class PatientLoginController : ApiController
    {
        PatientLoginBll bll = new PatientLoginBll();
        /// <summary>
        /// 病人注册
        /// </summary>
        /// <param name="patl">病人登陆实体类</param>
        /// <returns></returns>
        [HttpPost]
        public int PatientRegister(PatientLogin patl)
        {
            return bll.PatientRegister(patl);
        }
        /// <summary>
        /// 病人登陆
        /// </summary>
        /// <param name="PatientName">登陆名</param>
        /// <param name="PatientPwd">登陆密码</param>
        /// <returns></returns>
        [HttpGet]
        public int PatientLogin(string PatientName, string PatientPwd)
        {
            return bll.PatientLogin(PatientName, PatientPwd);
        }
    }
}
