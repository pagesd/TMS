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
    /// 付款
    /// </summary>
    public class HandleTMS : TMSRepository<PaymentModel>, HandleITMS
    {

        //添加
        public int HandleAdd(PaymentModel vm)
        {
            string sql = "insert into payment values (@id,@name,@money,@way,@pay_name,@opening_bank,@card_number,@payment_time,@describe,@comment,@image,@proposer,@create_time,@state)";
            int list = Dapper<PaymentModel>.RUD(sql, vm);
            return list;
        }
        //删除
        public int HandleDel(int id)
        {
            string sql = "DELETE  from payment where id=@id";
            int list = Dapper<PaymentModel>.RUD(sql, new { @id = id });
            return list;
        }
        //修改
        public int HandleEdit(PaymentModel vm)
        {
            string sql = "update payment set id=@id,name=@name,money=@money,way=@way,pay_name=@pay_name,opening_bank=@opening_bank,card_number=@card_number,payment_time=@payment_time,describe=@describe,comment=@comment,image=@image,proposer=@proposer,create_time=@create_time,state=@state where id=@id";
            int list = Dapper<PaymentModel>.RUD(sql, vm);
            return list;
        }
        //修改状态
        public int HandleEdit1(int id)
        {
            string sql = "update payment set state=1 where id=@id";
            int list = Dapper<PaymentModel>.RUD(sql, new { @id = id });
            return list;
        }
        //审批通过
        public int HandleEditTG(int id)
        {
            string sql = "update payment set state=3 where id=@id";
            int list = Dapper<PaymentModel>.RUD(sql, new { @id = id });
            return list;
        }
        //审批拒绝
        public int HandleEditJJ(int id)
        {
            string sql = "update payment set state=3 where id=@id";
            int list = Dapper<PaymentModel>.RUD(sql, new { @id = id });
            return list;
        }
        //反添
        public PaymentModel HandleFt(int id)
        {
            string sql = "select * from payment where id=@id";
            PaymentModel list = Dapper<PaymentModel>.QueryFirst(sql, new { @id = id });
            return list;
        }
        //显示
        public List<PaymentModel> HandleShow()
        {
            string sql = "select * from payment";
            List<PaymentModel> list = Dapper<PaymentModel>.Query(sql);
            return list;
        }
    }
}
