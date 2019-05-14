using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    //病人信息完善
    public class PatientBll
    {
        PatientDal dal = new PatientDal();
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
        /// 病人信息修改
        /// </summary>
        /// <param name="pa"></param>
        /// <returns></returns>
        public int PatientUpdate(Patient pa)
        {
            return dal.PatientUpdate(pa);
        }
    }
}
