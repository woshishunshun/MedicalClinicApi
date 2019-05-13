using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;
namespace DAL
{
    //管理员
    public class AdministratorDal
    {

        public List<StaffLogin> Login(string Name, string Pwd)
        {
            string sql = "select *from StaffLogin where Sl_Name='"+Name+"' and Sl_Pwd='"+Pwd+"'";
            var result = DBHelper.ExecuteScalar(sql);
            var table = JsonConvert.SerializeObject(result);
            var list = JsonConvert.DeserializeObject<List<StaffLogin>>(table);
            return list;
        }
        /// <summary>
        /// 显示医生
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<Doctor> doctorsShow(string Name)
        {
            string sql = "select *from Doctor inner join  Administrative on Doctor.Adm_Id=Administrative.Adm_Id where 1=1";
            if (!string.IsNullOrEmpty(Name))
            {
                sql += " and Doc_Name like '%{0}%'" + Name;
            }
            var result = DBHelper.ExecuteScalar(sql);
            var table = JsonConvert.SerializeObject(result);
            var list = JsonConvert.DeserializeObject<List<Doctor>>(table);
            return list;
        }
        /// <summary>
        /// 添加医生
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int DoctorAdd(Doctor m)
        {
            string sql = string.Format("insert into Doctor values('{0}','{1}','{2}','{3}','{4}','{5}')", m.Adm_Id, m.Doc_Name, m.Doc_Age, m.Doc_Sex, m.Doc_Time, m.Doc_Type);
            var result = DBHelper.ExecuteNonQuery(sql);
            return result;
        }
        /// <summary>
        /// 删除医生信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteDoctor(int id)
        {
            string sql = "delete from Doctor where Doc_Id='{0}'" + id;
            var result = DBHelper.ExecuteNonQuery(sql);
            return result;
        }
        /// <summary>
        /// 查询要修改的医生Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Doctor> UpdDoctor(int id)
        {
            string sql = "select *from Doctor where Doc_Id='{0}'" + id;
            var result = DBHelper.ExecuteScalar(sql);
            var table = JsonConvert.SerializeObject(result);
            var list = JsonConvert.DeserializeObject<List<Doctor>>(table);
            return list;
        }
        /// <summary>
        /// 修改反填数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int EditDoctor(Doctor m)
        {
            string sql = string.Format("update Doctor set Adm_Id='{0}',Doc_Name='{1}',Doc_Age='{2}',Doc_Sex='{3}',Doc_Sex='{4}',Doc_Time='{5}'", m.Adm_Id, m.Doc_Name, m.Doc_Age, m.Doc_Sex, m.Doc_Time, m.Doc_Type);
            var result = DBHelper.ExecuteNonQuery(sql);
            return result;
        }
    }
}
