using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;

namespace DAL
{
    public class NurseDal
    {
        /// <summary>
        /// 病人查询
        /// </summary>
        /// <param name="Pat_phone"></param>
        /// <returns></returns>
        public List<Patient> PatientShow(string Pat_phone)
        {
            string sql = "select * from Patient where Pat_Phone = " + Pat_phone;
            var ds = DBHelper.GetDataTable(sql);
            var js = JsonConvert.SerializeObject(ds);
            var jd = JsonConvert.DeserializeObject<List<Patient>>(js);
            return jd;
        }
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
        /// 挂号
        /// </summary>
        /// <param name="re"></param>
        /// <returns></returns>
        public int PatientLoginAdd(Registration re)
        {
            string sql = "insert into Patient values(" + re.Pat_Id + ",'" + re.Reg_Time + "'," + re.Adm_Id + "," + re.Doc_Id + "," + re.Reg_Type + ")";
            var da = DBHelper.ExecuteNonQuery(sql);
            return da;
        }
    }
}
