using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;
using TMS.IRepository;
using TMS.Model.Settlement;

namespace TMS.IRepository.Settlement
{
    /// <summary>
    /// 结算  应收
    /// </summary>
    public interface ReceivableITMS : TMSIRepository<ReceivableModel>
    {

        //显示
        List<ReceivableModel> ReceivableShow();
        //删除
        int ReceivableDel(int vehicleId);
        //添加
        int ReceivableAdd(ReceivableModel vm);
        //反添
        ReceivableModel ReceivableFt(int id);
        //修改
        int ReceivableEdit(ReceivableModel vm);
        //修改状态
        int ReceivableEdit1(int id);

    }
}
