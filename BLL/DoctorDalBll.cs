using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class DoctorBll
    {
        DoctorDal dl = new DoctorDal();
        /// <summary>
        /// 显示就诊记录
        /// </summary>
        /// <returns></returns>
        public List<Doctorecord> GetDoctorecords()
        {
            return dl.GetDoctorecords();
        }
        /// <summary>
        /// 添加就诊记录
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int AddGetDoctorecord(Doctorecord d)
        {
            return dl.AddGetDoctorecord(d);
        }
        /// <summary>
        /// 显示挂号
        /// </summary>
        /// <returns></returns>
        public List<Registration> GetRegistrations()
        {
            return dl.GetRegistrations();
        }
        /// <summary>
        /// 修改病人挂号状态
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int UptRegistrations(Registration r)
        {
            return dl.UptRegistrations(r);
        }
        /// <summary>
        /// 回访记录表
        /// </summary>
        /// <returns></returns>
        public List<Returnrecord> GetReturnrecords()
        {
            return dl.GetReturnrecords();
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public int LoginDoctor(string name, string pwd)
        {
            return dl.LoginDoctor(name, pwd);
        }
    }
}
