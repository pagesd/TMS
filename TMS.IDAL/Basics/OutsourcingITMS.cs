using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;

namespace TMS.IRepository.Basics
{
    /// <summary>
    /// 外协
    /// </summary>
    public interface OutsourcingITMS : TMSIRepository<OutsourceModel>
    {

        //显示
        List<OutsourceModel> OutsourcingShow();
        //删除
        int OutsourcingDel(int vehicleId);
        //添加
        int OutsourcingAdd(OutsourceModel vm);
        //反添
        OutsourceModel OutsourcingFt(int id);
        //修改
        int OutsourcingEdit(OutsourceModel vm);

    }
}
