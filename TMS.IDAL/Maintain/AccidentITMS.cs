using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model.Maintain;

namespace TMS.IRepository.Maintain
{
    /// <summary>
    /// 事故记录
    /// </summary>
    public interface AccidentITMS : TMSIRepository<AccidentModel>
    {

        //显示
        List<AccidentModel> AccidentShow();
        //删除
        int AccidentDel(int vehicleId);
        //添加
        int AccidentAdd(AccidentModel vm);
        //反添
        AccidentModel AccidentFt(int id);
        //修改
        int AccidentEdit(AccidentModel vm);

    }
}
