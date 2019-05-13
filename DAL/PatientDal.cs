using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    //病人信息完善
    public class PatientDal
    {
        public int PatientAdd(Patient pa)
        {
            string sql = "insert into Patient values(" + pa.PatLog_Id + ",'" + pa.Pat_Name + "','" + pa.Pat_Sex + "'," + pa.Pat_Age + ",'" + pa.Pat_Sfz + "','" + pa.Pat_Phone + "')";
            var da = DBHelper.ExecuteNonQuery(sql);
            return da;
        }
        
    }
}
