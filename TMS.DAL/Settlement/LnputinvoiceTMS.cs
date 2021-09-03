using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCommon;
using TMS.IRepository;
using TMS.Model.Settlement;
using TMS.IRepository.Settlement;


namespace TMS.Repository.Settlement
{
    /// <summary>
    /// 进项
    /// </summary>
    public class LnputinvoiceTMS : TMSRepository<CourseModel>, LnputinvoiceITMS
    {
        //添加
        public int LnputinvoiceAdd(CourseModel vm)
        {
            string sql = "insert into course values (@id,@invoiceId,@unit,@state,@money,@tax_rate,@invoice_time,@comment,@single,@create_time)";
            int list = Dapper<CourseModel>.RUD(sql, vm);
            return list;
        }
        //删除
        public int LnputinvoiceDel(int id)
        {
            string sql = "DELETE  from course where id=@id";
            int list = Dapper<CourseModel>.RUD(sql, new { @id = id });
            return list;
        }
        //修改
        public int LnputinvoiceEdit(CourseModel vm)
        {
            string sql = "update course set id=@id,invoiceId=@invoiceId,unit=@unit,state=@state,money=@money,tax_rate=@tax_rate,invoice_time=@invoice_time,comment=@comment,single=@single,create_time=@create_time where id=@id";
            int list = Dapper<CourseModel>.RUD(sql, vm);
            return list;
        }
        //反添
        public CourseModel LnputinvoiceFt(int id)
        {
            string sql = "select * from course where id=@id";
            CourseModel list = Dapper<CourseModel>.QueryFirst(sql, new { @id = id });
            return list;
        }
        //显示
        public List<CourseModel> LnputinvoiceShow()
        {
            string sql = "select * from course";
            List<CourseModel> list = Dapper<CourseModel>.Query(sql);
            return list;
        }


    }
}
