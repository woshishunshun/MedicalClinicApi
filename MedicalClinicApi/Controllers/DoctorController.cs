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
        ReturnrecordBll bl = new ReturnrecordBll();
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
        /// <summary>
        /// 添加回访记录表
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int AddReturnrecord(Returnrecord r)
        {
            return bl.AddReturnrecord(r);
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        [HttpGet]
        public int LoginDoctor(string name, string pwd)
        {
            int i = dl.LoginDoctor(name, pwd);
            return i;
        }
        [HttpGet]
        /// <summary>
        /// 查询登陆表所有数据
        /// </summary>
        /// <returns></returns>
        public List<StaffLogin> GetLoginTable()
        {
            return dl.GetLoginTable();
        }
   
    }
}
