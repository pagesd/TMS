using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model.Maintain;

namespace TMS.IRepository.Maintain
{
    public interface ViolationITMS : TMSIRepository<ViolationModel>
    {
        //显示
        List<ViolationModel> ViolationShow();
        //删除
        int ViolationDel(int vehicleId);
        //添加
        int ViolationAdd(ViolationModel vm);
        //反添
        ViolationModel ViolationFt(int id);
        //修改
        int ViolationEdit(ViolationModel vm);

    }
}
