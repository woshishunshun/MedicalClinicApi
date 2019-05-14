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
        /// 病人信息添加
        /// </summary>
        /// <param name="pa"></param>
        /// <returns></returns>
        public int PatientAdd(Patient pa)
        {
            return bll.PatientAdd(pa);
        }
        /// <summary>
        /// 病人信息修改
        /// </summary>
        /// <param name="pa"></param>
        /// <returns></returns>
        public int PatientUpdate(Patient pa)
        {
            return bll.PatientUpdate(pa);
        }
    }
}
