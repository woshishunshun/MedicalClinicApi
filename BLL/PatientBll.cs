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
        /// 完善病人信息
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public int PatientInfo(Patient patient)
        {
            return dal.PatientInfo(patient);
        }
    }
}
