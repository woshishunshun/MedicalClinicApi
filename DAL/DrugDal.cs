using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    //药品
    public class DrugDal
    {
        //获取药品信息
        public List<Drug> GetDrug()
        {
            return DBHelper.GetList<Drug>("select * from Drug");
        }
    }
}
