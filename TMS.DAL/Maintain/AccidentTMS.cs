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
    /// 事故记录
    /// </summary>
    public class AccidentTMS : TMSRepository<AccidentModel>, AccidentITMS
    {
        //添加
        public int AccidentAdd(AccidentModel vm)
        {
            string sql = "insert into accident values (@id,@title,@license_plate,@Incident,@accident_date,@compensation,@net_loss,@describe,@direct,@comment,@create_time)";
            int list = Dapper<AccidentModel>.RUD(sql, vm);
            return list;
        }
        //删除
        public int AccidentDel(int id)
        {
            string sql = "DELETE  from accident where id=@id";
            int list = Dapper<AccidentModel>.RUD(sql, new { @id = id });
            return list;
        }
        //修改
        public int AccidentEdit(AccidentModel vm)
        {
            string sql = "update accident set id=@id,title=@title,license_plate=@license_plate,Incident=@Incident,accident_date=@accident_date,compensation=@compensation,net_loss=@net_loss,describe=@describe,direct=@direct,comment=@comment,create_time=@create_time where id=@id";
            int list = Dapper<AccidentModel>.RUD(sql, vm);
            return list;
        }
        //反添
        public AccidentModel AccidentFt(int id)
        {
            string sql = "select * from accident where id=@id";
            AccidentModel list = Dapper<AccidentModel>.QueryFirst(sql, new { @id = id });
            return list;
        }
        //显示
        public List<AccidentModel> AccidentShow()
        {
            string sql = "select * from accident";
            List<AccidentModel> list = Dapper<AccidentModel>.Query(sql);
            return list;
        }


    }
}
