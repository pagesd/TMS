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
    public class MaintenanceTMS : TMSRepository<UpkeepModel>, MaintenanceITMS
    {

        //添加
        public int MaintenanceAdd(UpkeepModel vm)
        {
            string sql = "insert into upkeep values (@id,@name,@license_plate,@money,@principal,@mileage,@maintain_time,@maintain_mileage,@new_mileage,@maintain_item,@comment,@create_time)";
            int list = Dapper<UpkeepModel>.RUD(sql, vm);
            return list;
        }
        //删除
        public int MaintenanceDel(int id)
        {
            string sql = "DELETE  from upkeep where id=@id";
            int list = Dapper<UpkeepModel>.RUD(sql, new { @id = id });
            return list;
        }
        //修改
        public int MaintenanceEdit(UpkeepModel vm)
        {
            string sql = "update upkeep set id=@id,name=@name,license_plate=@license_plate,money=@money,principal=@principal,mileage=@mileage,maintain_time=@maintain_time,maintain_mileage=@maintain_mileage,new_mileage=@new_mileage,maintain_item=@maintain_item,comment=@comment,create_time=@create_time where id=@id";
            int list = Dapper<UpkeepModel>.RUD(sql, vm);
            return list;
        }
        //反添
        public UpkeepModel MaintenanceFt(int id)
        {
            string sql = "select * from upkeep where id=@id";
            UpkeepModel list = Dapper<UpkeepModel>.QueryFirst(sql, new { @id = id });
            return list;
        }
        //显示
        public List<UpkeepModel> MaintenanceShow()
        {
            string sql = "select * from upkeep";
            List<UpkeepModel> list = Dapper<UpkeepModel>.Query(sql);
            return list;
        }

    }
}
