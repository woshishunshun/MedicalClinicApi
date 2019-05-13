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
    public class AdministratorController : ApiController
    {
        AdministratorBll bll = new AdministratorBll();
        public List<StaffLogin> Login(string Name, string Pwd)
        {
            return bll.Login(Name, Pwd);
        }
        /// <summary>
        /// 显示医生
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<Doctor> doctorsShow(string Name)
        {
            return bll.doctorsShow(Name);
        }
        /// <summary>
        /// 添加医生
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int DoctorAdd(Doctor m)
        {
            return bll.DoctorAdd(m);
        }
        /// <summary>
        /// 删除医生信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteDoctor(int id)
        {
            return bll.DeleteDoctor(id);
        }
        /// <summary>
        /// 查询要修改的医生Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Doctor> UpdDoctor(int id)
        {
            return bll.UpdDoctor(id);
        }
        /// <summary>
        /// 修改反填数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int EditDoctor(Doctor m)
        {
            return bll.EditDoctor(m);
        }
        public List<StaffLogin> Login1(string Name, string Pwd)
        {
            return bll.Login(Name, Pwd);
        }

        /// <summary>
        /// 显示护士dd
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<Registration> RegistrationShow(string Name)
        {
            return bll.RegistrationShow(Name);
        }
        /// <summary>
        /// 添加护士
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int RegistrationAdd(Registration m)
        {
            return bll.RegistrationAdd(m);
        }
        /// <summary>
        /// 删除医生信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteRegistration(int id)
        {
            return bll.DeleteRegistration(id);
        }
        /// <summary>
        /// 查询要修改的医生Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Registration> UpdRegistration(int id)
        {
            return bll.UpdRegistration(id);
        }
        /// <summary>
        /// 修改反填数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int EditRegistration(Registration m)
        {
            return bll.EditRegistration(m);
        }
    }
}