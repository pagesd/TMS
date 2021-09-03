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
    /// 通用合同
    /// </summary>
    public class UniversalTMS : TMSRepository<UniversalModel>, UniversalITMS
    {
        #region//通用合同管理
        public int UniversalAdd(UniversalModel vm)
        {
            string sql = "insert into generalcontract values (null,@contracId,@name,@unit,@principal,@category,@signed_time,@agent,@contract_money,@contract_intro,@clause,@contract_text,@creation_time,@state,@approver)";
            int list = Dapper<UniversalModel>.RUD(sql, vm);
            return list;
        }

        public int UniversalDel(int id)
        {
            string sql = "DELETE  from generalcontract where id=@id";
            int list = Dapper<UniversalModel>.RUD(sql, new { @id = id });
            return list;
        }

        public int UniversalEdit(UniversalModel vm)
        {
            string sql = "update generalcontract set id=@id,contracId=@contracId,name=@name,unit=@unit,principal=@principal,category=@category,signed_time=@signed_time,agent=@agent,contract_money=@contract_money,contract_intro=@contract_intro,clause=@clause,contract_text=@contract_text,creation_time=@creation_time,state=@state,approver=@approver where id=@id";
            int list = Dapper<UniversalModel>.RUD(sql, vm);
            return list;
        }

        public int UniversalEdit1(int id)
        {
            string sql = "update generalcontract set state=1 where id=@id";
            int list = Dapper<UniversalModel>.RUD(sql, new { @id = id });
            return list;
        }
        //审批通过
        public int UniversalEditTG(int id)
        {
            string sql = "update generalcontract set state=2 where id=@id";
            int list = Dapper<UniversalModel>.RUD(sql, new { @id = id });
            return list;
        }
        //审批拒绝
        public int UniversalEditJJ(int id)
        {
            string sql = "update generalcontract set state=3 where id=@id";
            int list = Dapper<UniversalModel>.RUD(sql, new { @id = id });
            return list;
        }
        public UniversalModel UniversalFt(int id)
        {
            string sql = "select * from generalcontract where id=@id";
            UniversalModel list = Dapper<UniversalModel>.QueryFirst(sql, new { @id = id });
            return list;
        }

        public List<UniversalModel> UniversalShow()
        {
            string sql = "select * from generalcontract";
            List<UniversalModel> list = Dapper<UniversalModel>.Query(sql);
            return list;
        }

        #endregion
    }
}
