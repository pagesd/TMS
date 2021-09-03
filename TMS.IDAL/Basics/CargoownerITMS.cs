using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;

namespace TMS.IRepository.Basics
{
    /// <summary>
    /// 货主管理
    /// </summary>
    public interface CargoownerITMS : TMSIRepository<ShipperModel>
    {
        //显示
        List<ShipperModel> CargoownerShow();
        //删除
        int CargoownerDel(int vehicleId);
        //添加
        int CargoownerAdd(ShipperModel vm);
        //反添
        ShipperModel CargoownerFt(int id);
        //修改
        int CargoownerEdit(ShipperModel vm);

    }
}
