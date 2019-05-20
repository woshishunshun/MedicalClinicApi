using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
  public  class AppointmentDal
    {
        //预约信息
        /// <summary>
        /// 新增预约信息
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public int AddAppointment(Appointment appointment)
        {
            string strSql = string.Format("insert into Appointment values( '{0}','{1}','{2}',{3},{4},'{5}')",appointment.PatLog_Id,appointment.App_Date, appointment.App_Time,appointment.App_Administrative, appointment.App_Doctor, appointment.App_Remark);
            return DBHelper.ExecuteNonQuery(strSql);
        }

    }
}
