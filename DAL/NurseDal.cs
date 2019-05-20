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
        public List<Patient> PatientShow(string phone)
        {
            string sql = "select * from Patient where Pat_Phone = '" + phone + "'";
            var ds = DBHelper.GetDataTable(sql);
            var js = JsonConvert.SerializeObject(ds);
            var jd = JsonConvert.DeserializeObject<List<Patient>>(js);
            return jd;
        }
        /// <summary>
        /// 挂号
        /// </summary>
        /// <param name="re"></param>
        /// <returns></returns>
        public int PatientLoginAdd(Registration re)
        {
            string sql = "insert into Registration values(" + re.Pat_Id + ",'" + re.Reg_Time + "'," + re.Adm_Id + "," + re.Doc_Id + "," + re.Reg_Type + ")";
            var da = DBHelper.ExecuteNonQuery(sql);
            return da;
        }
        /// <summary>
        /// 护士账号登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public int NurseLogin(string name, string pwd)
        {
            string sql = string.Format("select count(*) from StaffLogin where Sl_Name='{0}' and Sl_Pwd='{1}' and Sl_Type=2", name, pwd);
            var da = DBHelper.ExecuteScalar(sql);
            return Convert.ToInt32(da);
        }
        /// <summary>
        /// 反填科室表
        /// </summary>
        /// <returns></returns>
        public List<Administrative> AdministrativeShow()
        {
            string sql = "select * from Administrative";
            var ds = DBHelper.GetDataTable(sql);
            var js = JsonConvert.SerializeObject(ds);
            var jd = JsonConvert.DeserializeObject<List<Administrative>>(js);
            return jd;
        }
        /// <summary>
        /// 二级联动医生表
        /// </summary>
        /// <param name="admId"></param>
        /// <returns></returns>
        public List<Doctor> DoctorShow(int admId)
        {
            string sql = "select Doc_Id,Doc_Name from Doctor where Adm_Id=" + admId;
            var ds = DBHelper.GetDataTable(sql);
            var js = JsonConvert.SerializeObject(ds);
            var jd = JsonConvert.DeserializeObject<List<Doctor>>(js);
            return jd;
        }
    }
    
}
