using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    /// <summary>
    /// 用户角色
    /// </summary>
    public class RoleusersModel
    {

        public int roleusersId { get; set; }        //主键
        public string roleId      { get; set; }     //角色
        public string usersId { get; set; }         //用户
    }
}
