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
        







        public List<Administrator> AdministratorsShow(string Name)
        {
            string sql = "select *from Administrator where 1=1";
            if (!string.IsNullOrEmpty(Name))
            {
                sql += " and Ads_Name like '%{0}%'" + Name;
            }
            var result = DBHelper.GetDataTable(sql);
            var table = JsonConvert.SerializeObject(result);
            var list = JsonConvert.DeserializeObject<List<Administrator>>(table);
            return list;
        }
    }
}
