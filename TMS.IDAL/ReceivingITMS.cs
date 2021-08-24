using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;

namespace TMS.IRepository
{
    /// <summary>
    /// 物资领用
    /// </summary>
    public interface ReceivingITMS : TMSIRepository<ReceivingModel>
    {
        //显示
        List<ReceivingModel> ReceivingShow();
        //删除
        int ReceivingDel(int id);
        //添加
        int ReceivingAdd(ReceivingModel vm);
        //反添
        ReceivingModel ReceivingFt(int id);
        //修改
        int ReceivingEdit(ReceivingModel vm);
        //修改状态
        int ReceivingEdit1(int id);


    }
}
