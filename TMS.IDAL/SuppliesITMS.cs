using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;
using TMS.IRepository;

namespace TMS.IRepository
{
    /// <summary>
    /// 物资采购
    /// </summary>
    public interface SuppliesITMS : TMSIRepository<PurchaseModel>
    {
        #region//物资采购
        //显示
        List<PurchaseModel> PurchaseShow();
        //删除
        int PurchaseDel(int vehicleId);
        //添加
        int PurchaseAdd(PurchaseModel vm);
        //反添
        PurchaseModel PurchaseFt(int vehicleId);
        //修改
        int PurchaseEdit(PurchaseModel vm);
        //修改状态
        int PurchaseEdit1(int id);
        #endregion

        #region//物资采购
        //修改
        int WarehousingEdit(PurchaseModel vm);
        //显示
        List<PurchaseModel> WarehousingShow();
        #endregion
    }
}
