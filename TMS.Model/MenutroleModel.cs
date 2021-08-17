using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    /// <summary>
    /// 角色菜单
    /// </summary>
    public class MenutroleModel
    {

        public int menuroleId { get; set; }     //主键
        public int menuId     { get; set; }     //菜单外键
        public int roleId     { get; set; }     //角色外键

    }
}
