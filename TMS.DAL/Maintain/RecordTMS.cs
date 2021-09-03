using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model.Maintain;
using TMS.Repository;
using DataCommon;
using TMS.IRepository.Maintain;

namespace TMS.Repository.Maintain
{
    /// <summary>
    /// 维修
    /// </summary>
    public class RecordTMS : TMSRepository<MaintainModel>, RecordITMS
    {

        //添加
        public int RecordAdd(MaintainModel vm)
        {
            string sql = "insert into maintain values (@id,@Name,@type,@license_plate,@money,@principal,@describe,@maintain_time,@comment,@create_time)";
            int list = Dapper<MaintainModel>.RUD(sql, vm);
            return list;
        }
        //删除
        public int RecordDel(int id)
        {
            string sql = "DELETE  from maintain where id=@id";
            int list = Dapper<MaintainModel>.RUD(sql, new { @id = id });
            return list;
        }
        //修改
        public int RecordEdit(MaintainModel vm)
        {
            string sql = "update maintain set id=@id,Name=@Name,type=@type,license_plate=@license_plate,money=@money,principal=@principal,describe=@describe,maintain_time=@maintain_time,comment=@comment,create_time=@create_time where id=@id";
            int list = Dapper<MaintainModel>.RUD(sql, vm);
            return list;
        }
        //反添
        public MaintainModel RecordFt(int id)
        {
            string sql = "select * from maintain where id=@id";
            MaintainModel list = Dapper<MaintainModel>.QueryFirst(sql, new { @id = id });
            return list;
        }
        //显示
        public List<MaintainModel> RecordShow()
        {
            string sql = "select * from maintain";
            List<MaintainModel> list = Dapper<MaintainModel>.Query(sql);
            return list;
        }

    }
}
