using DataCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.IRepository.Basics;
using TMS.Model;

namespace TMS.Repository.Basics
{
    /// <summary>
    /// 货主管理
    /// </summary>
    public class CargoownerTMS : TMSRepository<ShipperModel>, CargoownerITMS
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<ShipperModel> CargoownerShow()
        {
            string sql = "select * from shipper";
            List<ShipperModel> list = Dapper<ShipperModel>.Query(sql);
            return list;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public int CargoownerAdd(ShipperModel vm)
        {
            string sql = "insert into shipper values (@shipperId,@name,@phone,@unitName,@valid_time,@valid_image,@comment,@creation_time)";
            int list = Dapper<ShipperModel>.RUD(sql, vm);
            return list;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public int CargoownerDel(int vehicleId)
        {
            string sql = "DELETE  from shipper where shipperId=@vehicleId";
            int list = Dapper<ShipperModel>.RUD(sql, new { @vehicleId = vehicleId });
            return list;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public int CargoownerEdit(ShipperModel vm)
        {
            string sql = "update shipper set shipperId=@shipperId,name=@name,phone=@phone,unitName=@unitName,valid_time=@valid_time,valid_image=@valid_image,comment=@comment,creation_time=@creation_time where shipperId=@vehicleId";
            int list = Dapper<ShipperModel>.RUD(sql, vm);
            return list;
        }
        /// <summary>
        /// 反添
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public ShipperModel CargoownerFt(int id)
        {
            string sql = "select * from shipper where shipperId=@id";
            ShipperModel list = Dapper<ShipperModel>.QueryFirst(sql, new { @shipperId = id });
            return list;
        }

    }
}
