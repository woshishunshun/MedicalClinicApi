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
    //医生
    public class DoctorController : ApiController
    {
        DoctorBll dl = new DoctorBll();
        /// <summary>
        /// 显示就诊记录
        /// </summary>
        /// <returns></returns>
        public List<Doctorecord> GetDoctorecords()
        {
            return dl.GetDoctorecords();
        }
        /// <summary>
        /// 添加就诊记录
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int AddGetDoctorecord(Doctorecord d)
        {
            return dl.AddGetDoctorecord(d);
        }
        /// <summary>
        /// 显示挂号
        /// </summary>
        /// <returns></returns>
        public List<Registration> GetRegistrations()
        {
            return dl.GetRegistrations();
        }
        /// <summary>
        /// 修改病人挂号状态
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int UptRegistrations(Registration r)
        {
            return dl.UptRegistrations(r);
        }
        /// <summary>
        /// 回访记录表
        /// </summary>
        /// <returns></returns>
        public List<Returnrecord> GetReturnrecords()
        {
            return dl.GetReturnrecords();
        }
    }
}
