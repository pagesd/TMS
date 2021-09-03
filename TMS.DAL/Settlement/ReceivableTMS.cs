using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;
using TMS.Repository;
using DataCommon;
using TMS.IRepository;
using TMS.Model.Settlement;
using TMS.IRepository.Settlement;

namespace TMS.Repository.Settlement
{
    /// <summary>
    /// 结算   应收
    /// </summary>
    public class ReceivableTMS : TMSRepository<ReceivableModel>, ReceivableITMS
    {

        //添加
        public int ReceivableAdd(ReceivableModel vm)
        {
            string sql = "insert into receivable values (@id,@odd,@unit,@way,@tonnage,@price,@money,@business_time,@agent,@comment,@collator,@proof_time,@create_time,@state)";
            int list = Dapper<ReceivableModel>.RUD(sql, vm);
            return list;
        }
        //删除
        public int ReceivableDel(int id)
        {
            string sql = "DELETE  from receivable where id=@id";
            int list = Dapper<ReceivableModel>.RUD(sql, new { @id = id });
            return list;
        }
        //修改
        public int ReceivableEdit(ReceivableModel vm)
        {
            string sql = "update receivable set id=@id,odd=@odd,unit=@unit,way=@way,tonnage=@tonnage,price=@price,money=@money,business_time=@business_time,agent=@agent,comment=@comment,collator=@collator,proof_time=@proof_time,create_time=@create_time,state=@state where id=@id";
            int list = Dapper<ReceivableModel>.RUD(sql, vm);
            return list;
        }
        //修改状态
        public int ReceivableEdit1(int id)
        {
            string sql = "update receivable set state=1 where id=@id";
            int list = Dapper<ReceivableModel>.RUD(sql, new { @id = id });
            return list;
        }
        //反添
        public ReceivableModel ReceivableFt(int id)
        {
            string sql = "select * from receivable where id=@id";
            ReceivableModel list = Dapper<ReceivableModel>.QueryFirst(sql, new { @id = id });
            return list;
        }
        //显示
        public List<ReceivableModel> ReceivableShow()
        {
            string sql = "select * from receivable";
            List<ReceivableModel> list = Dapper<ReceivableModel>.Query(sql);
            return list;
        }

    }
}
