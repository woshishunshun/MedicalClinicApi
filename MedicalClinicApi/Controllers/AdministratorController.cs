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

        /// <summary>
        /// 显示医生
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Doctor> doctorsShow(string Name="")
        {
            return bll.doctorsShow(Name);
        }
        /// <summary>
        /// 添加医生
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPost]
        public int DoctorAdd(Doctor m)
        {
            return bll.DoctorAdd(m);
        }
        /// <summary>
        /// 删除医生信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DeleteDoctor(int id)
        {
            return bll.DeleteDoctor(id);
        }
        /// <summary>
        /// 查询要修改的医生Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Doctor> UpdDoctor(int id)
        {
            return bll.UpdDoctor(id);
        }
        /// <summary>
        /// 修改反填数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPut]
        public int EditDoctor(Doctor m)
        {
            return bll.EditDoctor(m);
        }
        [HttpGet]
        public List<StaffLogin> Login1(string Name, string Pwd)
        {
            return bll.Login(Name, Pwd);
        }

        /// <summary>
        /// 显示护士dd
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Nurse> NurseShow(string Name)
        {
            return bll.NurseShow(Name);
        }
        /// <summary>
        /// 添加护士
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPost]
        public int NurseAdd(Nurse m)
        {
            return bll.NurseAdd(m);
        }
        /// <summary>
        /// 删除医生信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DeleteNurse(int id)
        {
            return bll.DeleteNurse(id);
        }
        /// <summary>
        /// 查询要修改的医生Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Nurse> UpdNurse(int id)
        {
            return bll.UpdNurse(id);
        }
        /// <summary>
        /// 修改反填数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPut]
        public int EditNurse(Nurse m)
        {
            return bll.EditNurse(m);
        }
        [HttpGet]
        public List<StaffLogin> Login()
        {
            return bll.Login();
        }

    }
}