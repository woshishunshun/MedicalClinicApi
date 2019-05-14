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
    //挂号
    public class RegistrationController : ApiController
    {
        RegistrationBll bll = new RegistrationBll();
        /// <summary>
        /// 挂号
        /// </summary>
        /// <param name="re"></param>
        /// <returns></returns>
        public int PatientLoginAdd(Registration re)
        {
            return bll.PatientLoginAdd(re);
        }
    }
}
