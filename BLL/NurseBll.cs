using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;

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
        /// 不可重复挂号
        /// </summary>
        /// <param name="re"></param>
        /// <returns></returns>
        public int PatientLoginShow(int pat_id, string reg_time, int doc_id)
        {
            return dal.PatientLoginShow(pat_id,reg_time,doc_id);
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
        /// <summary>
        /// 根据时间查询预约挂号
        /// </summary>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public List<Patient> AppointmentShow(string date, string time)
        {
            return dal.AppointmentShow(date, time);
        }
        /// <summary>
        /// 获取预约查询病人
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Registration> PatientShows(int id)
        {
            return dal.PatientShows(id);
        }
    }
}
