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
        /// 病人信息添加
        /// </summary>
        /// <param name="pa"></param>
        /// <returns></returns>
        public int PatientAdd(Patient pa)
        {
            string sql = "insert into Patient values(" + pa.PatLog_Id + ",'" + pa.Pat_Name + "','" + pa.Pat_Sex + "'," + pa.Pat_Age + ",'" + pa.Pat_Sfz + "','" + pa.Pat_Phone + "')";
            var da = DBHelper.ExecuteNonQuery(sql);
            return da;
        }
        /// <summary>
        /// 病人信息修改
        /// </summary>
        /// <param name="pa"></param>
        /// <returns></returns>
        public int PatientUpdate(Patient pa)
        {
            string sql = "update Patient set PatLog_Id=" + pa.PatLog_Id + ",Pat_Name='" + pa.Pat_Name + "',Pat_Sex='" + pa.Pat_Sex + "',Pat_Age=" + pa.Pat_Age + ",Pat_Sfz='" + pa.Pat_Sfz + "',Pat_Phone='" + pa.Pat_Phone + "' where Pat_Id = " + pa.Pat_Id + "";
            var da = DBHelper.ExecuteNonQuery(sql);
            return da;
        }
    }
}
