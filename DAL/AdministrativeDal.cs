using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;

namespace DAL
{
    //科室
    public class AdministrativeDal
    {
        /// <summary>
        /// 查询科室表 用于绑定下拉列表
        /// </summary>
        /// <returns></returns>
        public List<Administrative> ShowAdministrative()
        {
            string strSql = "select * from Administrative";
            var table= DBHelper.GetDataTable(strSql);
            var json = JsonConvert.SerializeObject(table);
            return JsonConvert.DeserializeObject<List<Administrative>>(json);
        }
    }
}
