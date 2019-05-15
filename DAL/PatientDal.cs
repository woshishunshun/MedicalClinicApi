using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    //病人信息完善
    public class PatientDal
    {
        /// <summary>
        /// 完善病人信息
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public int PatientInfo(Patient patient)
        {
            string strSql = string.Format("insert into Patient values({0},'{1}','{2}',{3},'{4}','{5}')",patient.PatLog_Id,patient.Pat_Name,patient.Pat_Sex,patient.Pat_Age,patient.Pat_Sfz,patient.Pat_Phone);
            return DBHelper.ExecuteNonQuery(strSql);
        }
    }
}
