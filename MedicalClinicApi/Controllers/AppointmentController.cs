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
    public class AppointmentController : ApiController
    {
        AppointmentBll bll = new AppointmentBll();
        /// <summary>
        /// 新增预约信息
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddAppointment(Appointment appointment)
        {
            return bll.AddAppointment(appointment);
        }
    }
}
