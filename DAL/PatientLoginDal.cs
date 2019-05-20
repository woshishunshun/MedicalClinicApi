using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;

namespace DAL
{
    //病人登录表
   public class PatientLoginDal
    {
        /// <summary>
        /// 病人注册
        /// </summary>
        /// <param name="patl">病人登陆实体类</param>
        /// <returns></returns>
        public int PatientRegister(PatientLogin patl)
        {
            string strSql = string.Format("insert into PatientLogin values('{0}','{1}','{2}')", patl.PatLog_LogName,patl.PatLog_LogPwd,patl.PatLog_Time);
            return DBHelper.ExecuteNonQuery(strSql);
        }
        /// <summary>
        /// 病人登陆
        /// </summary>
        /// <param name="PatientName">登陆名</param>
        /// <param name="PatientPwd">登陆密码</param>
        /// <returns></returns>
        public int PatientLogin(string PatientName,string PatientPwd)
        {
            string strSql = "select count(*) from PatientLogin where PatLog_LogName='"+ PatientName + "' and PatLog_LogPwd='"+ PatientPwd + "'";
            return Convert.ToInt32(DBHelper.ExecuteScalar(strSql));
        }
        /// <summary>
        /// 获取病人登陆表所有信息
        /// </summary>
        /// <returns></returns>
        public List<PatientLogin> GetPatient()
        {
            string strSql = "select * from PatientLogin";
            var table= DBHelper.GetDataTable(strSql);
            var json = JsonConvert.SerializeObject(table);
            return JsonConvert.DeserializeObject<List<PatientLogin>>(json);
        }
    }
}
