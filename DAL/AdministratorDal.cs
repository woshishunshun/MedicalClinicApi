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

        //public int AdministratorsAdd(Administrator m)
        //{
        //    string sql = string.Format("insert into Administrator values('{0}','{1}')", m.Ads_Name, m.Ads_Pwd);
        //    var table = DBHelper.ExecuteNonQuery(sql);
        //    return table;
        //}




        //public List<Administrator> AdministratorsShow(string Name)
        //{
        //    string sql = "select *from Administrator where 1=1";
        //    if (!string.IsNullOrEmpty(Name))
        //    {
        //        sql += " and Ads_Name like '%{0}%'" + Name;
        //    }
        //    var result = DBHelper.GetDataTable(sql);
        //    var table = JsonConvert.SerializeObject(result);
        //    var list = JsonConvert.DeserializeObject<List<Administrator>>(table);
        //    return list;
        //}
    }
}
