using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model.Maintain;

namespace TMS.IRepository.Maintain
{
    /// <summary>
    /// 轮胎使用
    /// </summary>
    public interface TireuseITMS : TMSIRepository<TyreModel>
    {


        //显示
        List<TyreModel> TireuseShow();
        //删除
        int TireuseDel(int vehicleId);
        //添加
        int TireuseAdd(TyreModel vm);
        //反添
        TyreModel TireuseFt(int id);
        //修改
        int TireuseEdit(TyreModel vm);

    }
}
