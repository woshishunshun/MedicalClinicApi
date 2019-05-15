using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    //科室
    public class AdministrativeBll
    {
        AdministrativeDal dal = new AdministrativeDal();
        /// <summary>
        /// 查询科室表 用于绑定下拉列表
        /// </summary>
        /// <returns></returns>
        public List<Administrative> ShowAdministrative()
        {
            return dal.ShowAdministrative();
        }
    }
}
