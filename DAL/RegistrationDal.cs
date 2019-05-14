using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;
namespace DAL
{
    //挂号
    public class RegistrationDal
    {
        /// <summary>
        /// 挂号
        /// </summary>
        /// <param name="re"></param>
        /// <returns></returns>
        public int PatientLoginAdd(Registration re)
        {
            string sql = "insert into Patient values(" + re.Pat_Id + ",'" + re.Reg_Time + "'," + re.Adm_Id + "," + re.Doc_Id + "," + re.Reg_Type + ")";
            var da = DBHelper.ExecuteNonQuery(sql);
            return da;
        }
    }
}
