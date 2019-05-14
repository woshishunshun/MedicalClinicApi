using Model;
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
            string sql = string.Format("insert into Registration values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",d.Dcr_Id,d.Doc_Id,d.Adm_Id,d.Pat_Id,d.Dcr_Remake,d.Dcr_Time,d.Dr_Id);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 显示挂号
        /// </summary>
        /// <returns></returns>
        public List<Registration> GetRegistrations()
        {
            return DBHelper.GetList<Registration>("select * from Doctorecord");
        }
        /// <summary>
        /// 修改病人挂号状态
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int UptRegistrations(Registration r)
        {
            string sql = string.Format(@"UPDATE [dbo].[Registration]
   SET[Pat_Id] = '{0}',
      ,[Reg_Time] ='{1}',
      ,[Adm_Id] = '{2}',
      ,[Doc_Id] = '{3}',
      ,[Reg_Type] = '{4}',
 WHERE Reg_Id = '{5}'", r.Pat_Id, r.Reg_Time, r.Adm_Id, r.Doc_Id, r.Reg_Type, r.Reg_Id);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 回访记录表
        /// </summary>
        /// <returns></returns>
        public List<Returnrecord> GetReturnrecords()
        {
            return DBHelper.GetList<Returnrecord>("select * from Returnrecord r join Patient p on r.Pat_Id = p.Pat_Id");
        }
        
    }
}
