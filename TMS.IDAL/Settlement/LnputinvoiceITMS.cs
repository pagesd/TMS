using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model.Settlement;

namespace TMS.IRepository.Settlement
{
    /// <summary>
    /// 结算   进项
    /// </summary>
    public interface LnputinvoiceITMS : TMSIRepository<CourseModel>
    {
        //显示
        List<CourseModel> LnputinvoiceShow();
        //删除
        int LnputinvoiceDel(int vehicleId);
        //添加
        int LnputinvoiceAdd(CourseModel vm);
        //反添
        CourseModel LnputinvoiceFt(int id);
        //修改
        int LnputinvoiceEdit(CourseModel vm);
    }
}
