using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class NurseBll
    {
        NurseDal dal = new NurseDal();
        /// <summary>
        /// 病人查询
        /// </summary>
        /// <param name="Pat_phone"></param>
        /// <returns></returns>
        public List<Patient> PatientShow(string phone)
        {
            return dal.PatientShow(phone);
        }
        /// <summary>
        /// 挂号
        /// </summary>
        /// <param name="re"></param>
        /// <returns></returns>
        public int PatientLoginAdd(Registration re)
        {
            return dal.PatientLoginAdd(re);
        }
        /// <summary>
        /// 护士账号登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public int NurseLogin(string name, string pwd)
        {
            return dal.NurseLogin(name,pwd);
        }
        /// <summary>
        /// 反填科室表
        /// </summary>
        /// <returns></returns>
        public List<Administrative> AdministrativeShow()
        {
            return dal.AdministrativeShow();
        }
        /// <summary>
        /// 二级联动医生表
        /// </summary>
        /// <param name="admId"></param>
        /// <returns></returns>
        public List<Doctor> DoctorShow(int admId)
        {
            return dal.DoctorShow(admId);
        }
    }
}
