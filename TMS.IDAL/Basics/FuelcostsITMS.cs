using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;

namespace TMS.IRepository.Basics
{
    /// <summary>
    /// 油费
    /// </summary>
    public interface FuelcostsITMS : TMSIRepository<FuelModel>
    {

        //显示
        List<FuelModel> FuelcostsShow();
        //删除
        int FuelcostsDel(int vehicleId);
        //添加
        int FuelcostsAdd(FuelModel vm);
        //反添
        FuelModel FuelcostsFt(int id);
        //修改
        int FuelcostsEdit(FuelModel vm);

    }
}
