using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;

namespace TMS.IRepository.Personnel
{
    /// <summary>
    /// 入职办理
    /// </summary>
    public interface OnboardingITMS : TMSIRepository<StaffModel>
    {

        //显示
        List<StaffModel> OnboardingShow();
        //删除
        int OnboardingDel(int id);
        //添加
        int OnboardingAdd(StaffModel vm);
        //反添
        StaffModel OnboardingFt(int id);
        //修改
        int OnboardingEdit(StaffModel vm);

    }
}
