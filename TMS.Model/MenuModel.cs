using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    /// <summary>
    /// 菜单表
    /// </summary>
    public class MenuModel
    {
        public int menuId   { get; set; }           //主键
        public string menuName { get; set; }        //菜单名称
        public string url  { get; set; }            //路由
        public int menuWId { get; set; }            //外键

    }
    
}
