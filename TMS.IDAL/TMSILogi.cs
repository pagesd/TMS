using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;
using TMS.IRepository;

namespace TMS.IRepository
{
    //登录接口
    public interface TMSILogi: TMSIRepository<UsersModel>
    {
        //查询数据库账号密码
        UsersModel Login(string admin, string pwd);

    }
}
