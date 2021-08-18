using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;

namespace TMS.IRepository
{
    /// <summary>
    /// 人事
    /// </summary>
    public interface StaffITMS
    {
        //显示
        List<StaffModel> StaffShow();
        //删除
        int StaffDel(int id);
        //添加
        int StaffAdd(StaffModel vm);
        //反添
        StaffModel StaffFt(int id);
        //修改
        int StaffEdit(StaffModel vm);

    }
}
