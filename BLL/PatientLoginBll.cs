using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    //病人登陆
   public class PatientLoginBll
    {
        PatientLoginDal patldal = new PatientLoginDal();
        /// <summary>
        /// 病人注册
        /// </summary>
        /// <param name="patl">病人登陆实体类</param>
        /// <returns></returns>
        public int PatientRegister(PatientLogin patl)
        {
            return patldal.PatientRegister(patl);
        }
        /// <summary>
        /// 病人登陆
        /// </summary>
        /// <param name="PatientName">登陆名</param>
        /// <param name="PatientPwd">登陆密码</param>
        /// <returns></returns>
        public int PatientLogin(string PatientName, string PatientPwd)
        {
            return patldal.PatientLogin(PatientName, PatientPwd);
        }
    }
}
