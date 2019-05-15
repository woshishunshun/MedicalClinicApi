using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    //回访记录表
    public class ReturnrecordBll
    {
        ReturnrecordDal dl = new ReturnrecordDal();
        /// <summary>
        /// 添加回访记录表
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int AddReturnrecord(Returnrecord r)
        {
            return dl.AddReturnrecord(r);
        }
    }
}
