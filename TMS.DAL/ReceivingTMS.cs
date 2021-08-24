using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;
using TMS.Repository;
using DataCommon;
using TMS.IRepository;

namespace TMS.Repository
{
    public class ReceivingTMS : TMSRepository<ReceivingModel>, ReceivingITMS
    {

        //添加
        public int ReceivingAdd(ReceivingModel vm)
        {
            string sql = "insert into receive values (@id,@name,@useis,@comment,@select,@recipient,@receive_time,@create_time,@state,@approver)";
            int list = Dapper<ReceivingModel>.RUD(sql, vm);
            return list;
        }
        //删除
        public int ReceivingDel(int id)
        {
            string sql = "DELETE  from receive where id=@id";
            int list = Dapper<ReceivingModel>.RUD(sql, new { @id = id });
            return list;
        }
        //修改
        public int ReceivingEdit(ReceivingModel vm)
        {
            string sql = "update receive set id=@id,name=@name,useis=@useis,comment=@comment,select=@select,recipient=@recipient,receive_time=@receive_time,create_time=@create_time,state=@state,approver=@approver where id=@id";
            int list = Dapper<ReceivingModel>.RUD(sql, vm);
            return list;
        }
        //修改状态
        public int ReceivingEdit1(int id)
        {
            string sql = "update receive set state=1 where id=@id";
            int list = Dapper<ReceivingModel>.RUD(sql, new { @id = id });
            return list;
        }
        //反添
        public ReceivingModel ReceivingFt(int id)
        {
            string sql = "select * from receive where id=@id";
            ReceivingModel list = Dapper<ReceivingModel>.QueryFirst(sql, new { @id = id });
            return list;
        }
        //显示
        public List<ReceivingModel> ReceivingShow()
        {
            string sql = "select * from receive";
            List<ReceivingModel> list = Dapper<ReceivingModel>.Query(sql);
            return list;
        }

    }
}
