using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;
using TMS.Repository;
using DataCommon;
using TMS.IRepository;
using TMS.IRepository.Basics;

namespace TMS.Repository.Basics
{
    /// <summary>
    /// 车辆管理
    /// </summary>
    public class BaseTMS : TMSRepository<VehicleModel>, BaseITMS
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> Vehicle()
        {
            string sql = "select * from vehicle";
            List<VehicleModel> list = Dapper<VehicleModel>.Query(sql);
            return list;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public int VehicleAdd(VehicleModel vm)
        {
            string sql = "insert into vehicle values (@vehicleId,@brandId,@plate_number,@Name,@company,@long_g,@color,@buy_tiem,@certificate,@expire_time,@yearexpire_time,@maintain,@yehicle_image,@insurance_image)";
            int list= Dapper<VehicleModel>.RUD(sql,vm);
            return list;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public int VehicleDel(int vehicleId)
        {
            string sql = "DELETE  from vehicle where vehicleId=@vehicleId";
            int list = Dapper<VehicleModel>.RUD(sql, new { @vehicleId= vehicleId });
            return list;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public int VehicleEdit(VehicleModel vm)
        {
            string sql = "update vehicle set brandId=@brandId,plate_number=@plate_number,Name=@Name,company=@company,long_g=@long_g,color=@color,buy_tiem=@buy_tiem,certificate=@certificate,expire_time=@expire_time,yearexpire_time=@yearexpire_time,maintain=@maintain where vehicleId=@vehicleId";
            int list = Dapper<VehicleModel>.RUD(sql, vm);
            return list;
        }
        /// <summary>
        /// 反添
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public VehicleModel VehicleFt(int vehicleId)
        {
            string sql = "select * from vehicle where vehicleId=@vehicleId";
            VehicleModel list = Dapper<VehicleModel>.QueryFirst(sql, new { @vehicleId = vehicleId });
            return list;
        }
    }
}
