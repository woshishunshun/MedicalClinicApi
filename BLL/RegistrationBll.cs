using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    //挂号
    public class RegistrationBll
    {
        RegistrationDal dal = new RegistrationDal();
        public List<StaffLogin> Login(string Name, string Pwd)
        {
            return dal.Login(Name, Pwd);
        }
        /// <summary>
        /// 显示护士
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<Registration> RegistrationShow(string Name)
        {
            return dal.RegistrationShow(Name);
        }
        /// <summary>
        /// 添加护士
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int RegistrationAdd(Registration m)
        {
            return dal.RegistrationAdd(m);
        }
        /// <summary>
        /// 删除医生信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteRegistration(int id)
        {
            return dal.DeleteRegistration(id);
        }
        /// <summary>
        /// 查询要修改的医生Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Registration> UpdRegistration(int id)
        {
            return dal.UpdRegistration(id);
        }
        /// <summary>
        /// 修改反填数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int EditRegistration(Registration m)
        {
            return dal.EditRegistration(m);
        }
    }
}
