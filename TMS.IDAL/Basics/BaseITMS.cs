using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;
using TMS.IRepository;

namespace TMS.IRepository.Basics
{
    /// <summary>
    /// 车辆管理
    /// </summary>
    public interface BaseITMS :TMSIRepository<VehicleModel>
    {
        //显示
        List<VehicleModel> Vehicle();
        //删除
        int VehicleDel(int vehicleId);
        //添加
        int VehicleAdd(VehicleModel vm);
        //反添
        VehicleModel VehicleFt(int vehicleId);
        //修改
        int VehicleEdit(VehicleModel vm);
    }
}
