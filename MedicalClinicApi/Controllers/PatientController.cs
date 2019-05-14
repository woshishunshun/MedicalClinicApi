using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;

namespace MedicalClinicApi.Controllers
{
    //病人个人信息
    public class PatientController : ApiController
    {
        PatientBll bll = new PatientBll();
        /// <summary>
        /// 完善病人信息
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        [HttpPost]
        public int PatientInfo(Patient patient)
        {
            return bll.PatientInfo(patient);
        }
    }
}
