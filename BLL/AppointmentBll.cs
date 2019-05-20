using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
   public class AppointmentBll
    {
        AppointmentDal dal = new AppointmentDal();
        /// <summary>
        /// 新增预约信息
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public int AddAppointment(Appointment appointment)
        {
            return dal.AddAppointment(appointment);
        }
    }
}
