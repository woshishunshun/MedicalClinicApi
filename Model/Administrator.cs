using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Administrator
    {
        public int Ads_Id { get; set; }// 主键  管理员表Id
        public string Ads_Name { get; set; }//  管理员登陆name
        public string Ads_Pwd { get; set; }// 管理员登陆密码
    }
}
