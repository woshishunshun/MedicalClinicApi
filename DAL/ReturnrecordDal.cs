using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    //回访记录表
    public class ReturnrecordDal
    {
        /// <summary>
        /// 添加回访记录表
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int AddReturnrecord(Returnrecord r)
        {
            string sql = string.Format("insert into Returnrecord values('{0}','{1}','{2}','{3}')", r.Pat_Id, r.Rer_Id, r.Rer_Time);
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
