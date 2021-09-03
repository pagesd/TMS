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
    public class TireuseTMS : TMSRepository<TyreModel>, TireuseITMS
    {

        //添加
        public int TireuseAdd(TyreModel vm)
        {
            string sql = "insert into tyre values (@id,@license_plate,@brand,@standard,@number,@user,@use_time,@comment,@create_time)";
            int list = Dapper<TyreModel>.RUD(sql, vm);
            return list;
        }
        //删除
        public int TireuseDel(int id)
        {
            string sql = "DELETE  from tyre where id=@id";
            int list = Dapper<TyreModel>.RUD(sql, new { @id = id });
            return list;
        }
        //修改
        public int TireuseEdit(TyreModel vm)
        {
            string sql = "update tyre set id=@id,license_plate=@license_plate,brand=@brand,standard=@standard,number=@number,user=@user,use_time=@use_time,comment=@comment,create_time=@create_time where id=@id";
            int list = Dapper<TyreModel>.RUD(sql, vm);
            return list;
        }
        //反添
        public TyreModel TireuseFt(int id)
        {
            string sql = "select * from tyre where id=@id";
            TyreModel list = Dapper<TyreModel>.QueryFirst(sql, new { @id = id });
            return list;
        }
        //显示
        public List<TyreModel> TireuseShow()
        {
            string sql = "select * from tyre";
            List<TyreModel> list = Dapper<TyreModel>.Query(sql);
            return list;
        }

    }
}
