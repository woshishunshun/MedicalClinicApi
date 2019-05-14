using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    //挂号
    public class RegistrationBll
    {
        RegistrationDal dal = new RegistrationDal();
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
