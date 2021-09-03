using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model.Maintain;

namespace TMS.IRepository.Maintain
{
    /// <summary>
    /// 保养
    /// </summary>
    public interface MaintenanceITMS : TMSIRepository<UpkeepModel>
    {

        //显示
        List<UpkeepModel> MaintenanceShow();
        //删除
        int MaintenanceDel(int vehicleId);
        //添加
        int MaintenanceAdd(UpkeepModel vm);
        //反添
        UpkeepModel MaintenanceFt(int id);
        //修改
        int MaintenanceEdit(UpkeepModel vm);

    }
}
