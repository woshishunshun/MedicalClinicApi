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
            return DBHelper.GetList<StaffLogin>(sql);
        }
        public List<StaffLogin> Login()
        {
            string sql = "select *from StaffLogin";
            return DBHelper.GetList<StaffLogin>(sql);
            
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
            var result = DBHelper.GetList<Doctor>(sql);
            return result;
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
            var result = DBHelper.GetList<Doctor>(sql);
            return result;
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
        public List<StaffLogin> Login1(string Name, string Pwd)
        {
            string sql = "select *from StaffLogin where Sl_Name='" + Name + "' and Sl_Pwd='" + Pwd + "'";
            var result = DBHelper.GetList<StaffLogin>(sql);
            return result;
        }
        /// <summary>
        /// 显示护士
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<Nurse> NurseShow(string Name)
        {
            string sql = @"select *from Nurse where 1=1";
            if (!string.IsNullOrEmpty(Name))
            {
                sql += " and N_Name like '%{0}%'" + Name;
            }
            var result = DBHelper.GetList<Nurse>(sql);
            return result;
        }
        /// <summary>
        /// 添加护士
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int NurseAdd(Nurse m)
        {
            string sql = string.Format("insert into Nurse values('{0}','{1}','{2}','{3}','{4}')", m.N_Name, m.N_Age, m.N_Sex, m.N_Time, m.N_Type);
            var result = DBHelper.ExecuteNonQuery(sql);
            return result;
        }
        /// <summary>
        /// 删除医生信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteNurse(int id)
        {
            string sql = "delete from Nurse where N_Id='{0}'" + id;
            var result = DBHelper.ExecuteNonQuery(sql);
            return result;
        }
        /// <summary>
        /// 查询要修改的医生Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Nurse> UpdNurse(int id)
        {
            string sql = "select *from Nurse where N_Id='{0}'" + id;
            var result = DBHelper.GetList<Nurse>(sql);
            return result;
        }
        /// <summary>
        /// 修改反填数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int EditNurse(Nurse m)
        {
            string sql = string.Format("update Nurse set N_Name='{0}',N_Age='{1}',N_Sex='{2}',N_Time='{3}',N_Type='{4}'", m.N_Name, m.N_Age, m.N_Sex, m.N_Time, m.N_Type);
            var result = DBHelper.ExecuteNonQuery(sql);
            return result;
        }

         
    }
}
