using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model.Maintain;

namespace TMS.IRepository.Maintain
{
    /// <summary>
    /// 维修
    /// </summary>
    public interface RecordITMS : TMSIRepository<MaintainModel>
    {

        //显示
        List<MaintainModel> RecordShow();
        //删除
        int RecordDel(int vehicleId);
        //添加
        int RecordAdd(MaintainModel vm);
        //反添
        MaintainModel RecordFt(int id);
        //修改
        int RecordEdit(MaintainModel  vm);

    }
}
