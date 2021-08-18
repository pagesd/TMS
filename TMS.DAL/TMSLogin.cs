using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;
using TMS.Repository;
using TMS.Common;
using DataCommon;
using TMS.IRepository;
using Dapper;

namespace TMS.Repository
{
    public class TMSLogin:TMSRepository<UsersModel>, TMSILogi
    {
        //登录
        public UsersModel Login(string admin, string pwd)
        {
            string sql = "select * from users where admin=@admin and pwd=@pwd";
            UsersModel data = Dapper<UsersModel>.QueryFirst(sql, new { @admin = admin, @pwd = pwd });
            return data;
        }

    }
}
