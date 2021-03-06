﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{ 
    //医生
    public class DoctorDal
    {
        /// <summary>
        /// 显示就诊记录
        /// </summary>
        /// <returns></returns>
        public List<Doctorecord> GetDoctorecords()
        {
            return DBHelper.GetList<Doctorecord>(@"select * from Doctorecord dc join Doctor d on dc.Doc_Id = d.Doc_Id join Administrative a on dc.Adm_Id = a.Adm_Id
join Patient p on dc.Pat_Id = p.Pat_Id");
        }
        /// <summary>
        /// 添加就诊记录
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int AddGetDoctorecord(Doctorecord d)
        {
            string sql = string.Format("insert into [Doctorecord] values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", d.Doc_Id,d.Adm_Id,d.Pat_Id,d.Dcr_Remake,d.Dcr_Time,d.Dr_Name,d.Reg_Id);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 显示挂号
        /// </summary>
        /// <returns></returns>
        public List<Registration> GetRegistrations()
        {
            return DBHelper.GetList<Registration>(@"select * from [Registration] r join Patient p on p.Pat_Id = r.Pat_Id join Administrative a on a.Adm_Id = r.Adm_Id
  join Doctor d on d.Doc_Id = r.Doc_Id");
        }
        /// <summary>
        /// 修改病人挂号状态
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int UptRegistrations(Registration r)
        {
            string sql = string.Format(@"UPDATE [dbo].[Registration] SET[Pat_Id] = '{0}',[Reg_Time] ='{1}' ,[Adm_Id] = '{2}',[Doc_Id] = '{3}' ,[Reg_Type] = '{4}' WHERE Reg_Id = '{5}'", r.Pat_Id, r.Reg_Time, r.Adm_Id, r.Doc_Id, r.Reg_Type, r.Reg_Id);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 回访记录表
        /// </summary>
        /// <returns></returns>
        public List<Returnrecord> GetReturnrecords()
        {
            return DBHelper.GetList<Returnrecord>(@"select  *  from [Returnrecord] r join Doctor d on d.Doc_Id = r.Doc_Id join Registration r1 on r1.Reg_Id = r.Reg_Id
  join Patient p on p.Pat_Id = r1.Pat_Id");
        }
        /// <summary>
        /// 添加回访记录表
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int AddReturnrecord(Returnrecord r)
        {
            string sql = string.Format("insert into Returnrecord values('{0}','{1}','{2}','{3}')", r.Reg_Id, r.Rer_Remake, r.Rer_Time, r.Doc_Id);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public int LoginDoctor(string name, string pwd)
        {
            string sql = string.Format("select count(*) from StaffLogin where Sl_Name='{0}' and Sl_Pwd='{1}' and Sl_Type=1", name, pwd);
            int i = Convert.ToInt32(DBHelper.ExecuteScalar(sql));
            return i;
        }
         
        /// <summary>
        /// 查询登陆表所有数据
        /// </summary>
        /// <returns></returns>
        public List<StaffLogin> GetLoginTable()
        {
            return DBHelper.GetList<StaffLogin>("select * from StaffLogin");
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        public List<Doctor> GetDoctors()
        {
            return DBHelper.GetList<Doctor>("select * from Doctor");
        }
    }
}
