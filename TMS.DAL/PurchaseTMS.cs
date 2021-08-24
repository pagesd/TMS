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
    /// <summary>
    /// 物资采购
    /// </summary>
    public class PurchaseTMS : TMSRepository<PurchaseModel>, SuppliesITMS
    {

        #region//物资采购管理
        //添加
        public int PurchaseAdd(PurchaseModel vm)
        {
            string sql = "insert into procurement values (@id,@name,@type,@texture,@scale,@origin,@number,@expectation,@useis,@comment,@proposer,@create_time,@state,@approver,@way_money,@price,@buying)";
            int list = Dapper<PurchaseModel>.RUD(sql, vm);
            return list;
        }
        //删除
        public int PurchaseDel(int id)
        {
            string sql = "DELETE  from procurement where id=@id";
            int list = Dapper<PurchaseModel>.RUD(sql, new { @id = id });
            return list;
        }
        //修改
        public int PurchaseEdit(PurchaseModel vm)
        {
            string sql = "update procurement set id=@id,name=@name,type=@type,texture=@texture,scale=@scale,origin=@origin,number=@number,expectation=@expectation,useis=@useis,comment=@comment,proposer=@proposer,create_time=@create_time,state=@state,approver=@approver,way_money=@way_money,price=@price,buying=@buying where id=@id";
            int list = Dapper<PurchaseModel>.RUD(sql, vm);
            return list;
        }
        //修改状态
        public int PurchaseEdit1(int id)
        {
            string sql = "update procurement set state=1 where id=@id";
            int list = Dapper<PurchaseModel>.RUD(sql, new { @id = id });
            return list;
        }
        //反添
        public PurchaseModel PurchaseFt(int id)
        {
            string sql = "select * from procurement where id=@id";
            PurchaseModel list = Dapper<PurchaseModel>.QueryFirst(sql, new { @id = id });
            return list;
        }
        //显示
        public List<PurchaseModel> PurchaseShow()
        {
            string sql = "select * from procurement";
            List<PurchaseModel> list = Dapper<PurchaseModel>.Query(sql);
            return list;
        }

        #endregion

        #region//入库管理
        //修改
        public int WarehousingEdit(PurchaseModel vm)
        {
            string sql = "update procurement set way_money=@way_money,price=@price,buying=price*number where id=@id";
            int list = Dapper<PurchaseModel>.RUD(sql, vm);
            return list;
        }

        //显示
        public List<PurchaseModel> WarehousingShow()
        {
            string sql = "select * from procurement where state=1";
            List<PurchaseModel> list = Dapper<PurchaseModel>.Query(sql);
            return list;
        }
        #endregion
    }
}
