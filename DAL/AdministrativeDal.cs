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
        /// <summary>
        /// 查询医师表 绑定下拉
        /// </summary>
        /// <returns></returns>
        public List<Doctor> ShowDoctor(int id)
        {
            string strSql = "select * from Doctor where Adm_Id="+id;
            var table = DBHelper.GetDataTable(strSql);
            var json = JsonConvert.SerializeObject(table);
            return JsonConvert.DeserializeObject<List<Doctor>>(json);
        }
    }
}
