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
    public class CarriageTMS : TMSRepository<CarriagecontractModel>, CarriageITMS
    {
        #region//承运合同管理
        public int CarriageAdd(CarriagecontractModel vm)
        {
            string sql = "insert into carriagecontract values (@id,@contractId,@Name,@unit,@principal,@path,@price,@full_price,@full_money,@Signing_time,@agent,@creation_time,@state,@approval,@contract_time,@contract_explain,@contract_clause,@contract_text,@zt)";
            int list = Dapper<CarriagecontractModel>.RUD(sql, vm);
            return list;
        }

        public int CarriageDel(int id)
        {
            string sql = "DELETE  from carriagecontract where id=@id";
            int list = Dapper<CarriagecontractModel>.RUD(sql, new { @id = id });
            return list;
        }

        public int CarriageEdit(CarriagecontractModel vm)
        {
            string sql = "update carriagecontract set id=@id,contractId=@contractId,Name=@Name,unit=@unit,principal=@principal,path=@path,price=@price,full_price=@full_price,full_money=@full_money,Signing_time=@Signing_time,agent=@agent,creation_time=@creation_time,state=@state,approval=@approval,contract_time=@contract_time,contract_explain=@contract_explain,contract_clause=@contract_clause,contract_text=@contract_text where id=@id";
            int list = Dapper<CarriagecontractModel>.RUD(sql, vm);
            return list;
        }

        public int CarriageEdit1(int id)
        {
            string sql = "update carriagecontract set state=1 where id=@id";
            int list = Dapper<CarriagecontractModel>.RUD(sql, new { @id = id });
            return list;
        }
        //审批通过
        public int CarriageEditTG(int id)
        {
            string sql = "update carriagecontract set state=2 where id=@id";
            int list = Dapper<CarriagecontractModel>.RUD(sql, new { @id = id });
            return list;
        }
        //审批拒绝
        public int CarriageEditJJ(int id)
        {
            string sql = "update carriagecontract set state=3 where id=@id";
            int list = Dapper<CarriagecontractModel>.RUD(sql, new { @id = id });
            return list;
        }

        public CarriagecontractModel CarriageFt(int id)
        {
            string sql = "select * from carriagecontract where id=@id";
            CarriagecontractModel list = Dapper<CarriagecontractModel>.QueryFirst(sql, new { @id = id });
            return list;
        }

        public List<CarriagecontractModel> CarriageShow()
        {
            string sql = "select * from carriagecontract where zt=2";
            List<CarriagecontractModel> list = Dapper<CarriagecontractModel>.Query(sql);
            return list;
        }

        #endregion



        #region//货主合同管理
        public int ConsignorAdd(CarriagecontractModel vm)
        {
            string sql = "insert into carriagecontract values (@id,@contractId,@Name,@unit,@principal,@path,@price,@full_price,@full_money,@Signing_time,@agent,@creation_time,@state,@approval,@contract_time,@contract_explain,@contract_clause,@contract_text,@zt)";
            int list = Dapper<CarriagecontractModel>.RUD(sql, vm);
            return list;
        }

        public int ConsignorDel(int id)
        {
            string sql = "DELETE  from carriagecontract where id=@id";
            int list = Dapper<CarriagecontractModel>.RUD(sql, new { @id = id });
            return list;
        }

        public int ConsignorEdit(CarriagecontractModel vm)
        {
            string sql = "update carriagecontract set id=@id,contractId=@contractId,Name=@Name,unit=@unit,principal=@principal,path=@path,price=@price,full_price=@full_price,full_money=@full_money,Signing_time=@Signing_time,agent=@agent,creation_time=@creation_time,state=@state,approval=@approval,contract_time=@contract_time,contract_explain=@contract_explain,contract_clause=@contract_clause,contract_text=@contract_text where id=@id";
            int list = Dapper<CarriagecontractModel>.RUD(sql, vm);
            return list;
        }

        public int ConsignorEdit1(int id)
        {
            string sql = "update carriagecontract set state=1 where id=@id";
            int list = Dapper<CarriagecontractModel>.RUD(sql, new { @id = id });
            return list;
        }
        //审批通过
        public int ConsignorEditTG(int id)
        {
            string sql = "update carriagecontract set state=2 where id=@id";
            int list = Dapper<CarriagecontractModel>.RUD(sql, new { @id = id });
            return list;
        }
        //审批拒绝
        public int ConsignorEditJJ(int id)
        {
            string sql = "update carriagecontract set state=3 where id=@id";
            int list = Dapper<CarriagecontractModel>.RUD(sql, new { @id = id });
            return list;
        }

        public CarriagecontractModel ConsignorFt(int id)
        {
            string sql = "select * from carriagecontract where id=@id";
            CarriagecontractModel list = Dapper<CarriagecontractModel>.QueryFirst(sql, new { @id = id });
            return list;
        }

        public List<CarriagecontractModel> ConsignorShow()
        {
            string sql = "select * from carriagecontract where zt=1";
            List<CarriagecontractModel> list = Dapper<CarriagecontractModel>.Query(sql);
            return list;
        }
        #endregion



    }
}
