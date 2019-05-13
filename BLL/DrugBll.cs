using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    //药品
    public class DrugBll
    {
        DrugDal dl = new DrugDal();
        //获取药品信息
        public List<Drug> GetDrug()
        {
            return dl.GetDrug();
        }
    }
}
