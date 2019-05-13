using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;

namespace MedicalClinicApi.Controllers
{
    // 药品
    public class DrugController : ApiController
    {
        DrugBll bl = new DrugBll();
        public List<Drug> GetDrug()
        {
            return bl.GetDrug();
        }
    }
}
