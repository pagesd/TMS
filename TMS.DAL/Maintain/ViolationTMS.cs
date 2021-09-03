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
    /// 违章
    /// </summary>
    public class ViolationTMS : TMSRepository<ViolationModel>, ViolationITMS
    {

        //添加
        public int ViolationAdd(ViolationModel vm)
        {
            string sql = "insert into violation values (@id,@title,@license_plate,@violation_name,@violation_date,@violation_intro,@result,@comment,@create_time)";
            int list = Dapper<ViolationModel>.RUD(sql, vm);
            return list;
        }
        //删除
        public int ViolationDel(int id)
        {
            string sql = "DELETE  from violation where id=@id";
            int list = Dapper<ViolationModel>.RUD(sql, new { @id = id });
            return list;
        }
        //修改
        public int ViolationEdit(ViolationModel vm)
        {
            string sql = "update violation set id=@id,title=@title,license_plate=@license_plate,violation_name=@violation_name,violation_date=@violation_date,violation_intro=@violation_intro,result=@result,comment=@comment,create_time=@create_time where id=@id";
            int list = Dapper<ViolationModel>.RUD(sql, vm);
            return list;
        }
        //反添
        public ViolationModel ViolationFt(int id)
        {
            string sql = "select * from violation where id=@id";
            ViolationModel list = Dapper<ViolationModel>.QueryFirst(sql, new { @id = id });
            return list;
        }
        //显示
        public List<ViolationModel> ViolationShow()
        {
            string sql = "select * from violation";
            List<ViolationModel> list = Dapper<ViolationModel>.Query(sql);
            return list;
        }

    }
}
