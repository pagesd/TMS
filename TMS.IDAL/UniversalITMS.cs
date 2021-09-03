using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;
using TMS.IRepository;

namespace TMS.IRepository
{
    /// <summary>
    /// 通用合同
    /// </summary>
    public interface UniversalITMS : TMSIRepository<UniversalModel>
    {

        //#region//通用合同管理
        //显示
        List<UniversalModel> UniversalShow();
        //删除
        int UniversalDel(int id);
        //添加
        int UniversalAdd(UniversalModel vm);
        //反添
        UniversalModel UniversalFt(int id);
        //修改
        int UniversalEdit(UniversalModel vm);
        //修改状态
        int UniversalEdit1(int id);
        //审批
        //通过
        int UniversalEditTG(int id);
        //拒绝
        int UniversalEditJJ(int id);
        //#endregion

    }
}
