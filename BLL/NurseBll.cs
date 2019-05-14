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
        public List<Patient> PatientShow(string Pat_phone)
        {
            return dal.PatientShow(Pat_phone);
        }
        /// <summary>
        /// 病人信息添加
        /// </summary>
        /// <param name="pa"></param>
        /// <returns></returns>
        public int PatientAdd(Patient pa)
        {
            return dal.PatientAdd(pa);
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
    }
}
