using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;

namespace TMS.IRepository.Basics
{
    /// <summary>
    /// 线路
    /// </summary>
    public interface LineITMS : TMSIRepository<PathModel>
    {

        //显示
        List<PathModel> LineShow();
        //删除
        int LineDel(int vehicleId);
        //添加
        int LineAdd(PathModel vm);
        //反添
        PathModel LineFt(int id);
        //修改
        int LineEdit(PathModel vm);

    }
}
