using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;
using TMS.IRepository;

namespace TMS.IRepository
{
    public interface CarriageITMS : TMSIRepository<CarriagecontractModel>
    {
        #region//承运合同管理
        //显示
        List<CarriagecontractModel> CarriageShow();
        //删除
        int CarriageDel(int id);
        //添加
        int CarriageAdd(CarriagecontractModel vm);
        //反添
        CarriagecontractModel CarriageFt(int id);
        //修改
        int CarriageEdit(CarriagecontractModel vm);
        //修改状态
        int CarriageEdit1(int id);
        //审批
        //通过
        int CarriageEditTG(int id);
        //拒绝
        int CarriageEditJJ(int id);
        #endregion

        #region//货主合同管理
        //显示
        List<CarriagecontractModel> ConsignorShow();
        //删除
        int ConsignorDel(int id);
        //添加
        int ConsignorAdd(CarriagecontractModel vm);
        //反添
        CarriagecontractModel ConsignorFt(int id);
        //修改
        int ConsignorEdit(CarriagecontractModel vm);
        //修改状态
        int ConsignorEdit1(int id);
        //审批
        //通过
        int ConsignorEditTG(int id);
        //拒绝
        int ConsignorEditJJ(int id);
        #endregion

    }
}
