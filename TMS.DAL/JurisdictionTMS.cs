using Dapper;
using DataCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.IRepository;
using TMS.Model;

namespace TMS.Repository
{
    public class JurisdictionTMS : TMSRepository<MenuModel>, JurisdictionITMS
    {
        //查询权限
        public List<MenuModel> Use(int id)
        {
            DynamicParameters dp = new DynamicParameters();
            dp.Add("a.usersId", id);
            string sql = "select e.menuId,menuName from	users a JOIN roleusers b ON a.usersId=b.usersId join role c ON c.roleId = b.roleId JOIN menutrole d ON c.roleId = d.roleId  JOIN menu e ON d.menuId = e.menuId  where a.usersId = @a.usersId";
            List<MenuModel> list = Dapper<MenuModel>.Query(sql, dp);
            return list;
        }

        public List<MenuModel> Use2(int id)
        {
            DynamicParameters dp = new DynamicParameters();
            dp.Add("a.menuId", id);
            string sql = "select * from menu a join menu b on a.menuId=b.menuWId where a.menuId=@a.menuId";
            List<MenuModel> list = Dapper<MenuModel>.Query(sql, dp);
            return list;
        }
    }
}
