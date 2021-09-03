using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model.Settlement;

namespace TMS.IRepository.Settlement
{
    /// <summary>
    /// 付款
    /// </summary>
    public interface HandleITMS : TMSIRepository<PaymentModel>
    {

        //显示
        List<PaymentModel> HandleShow();
        //删除
        int HandleDel(int vehicleId);
        //添加
        int HandleAdd(PaymentModel vm);
        //反添
        PaymentModel HandleFt(int id);
        //修改
        int HandleEdit(PaymentModel vm);
        //修改状态
        int HandleEdit1(int id);
        //审批
        //通过
        int HandleEditTG(int id);
        //拒绝
        int HandleEditJJ(int id);

    }
}
