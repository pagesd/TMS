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
    /// 油费
    /// </summary>
    public class FuelcostsTMS : TMSRepository<FuelModel>, FuelcostsITMS
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<FuelModel> FuelcostsShow()
        {
            string sql = "select * from fuel";
            List<FuelModel> list = Dapper<FuelModel>.Query(sql);
            return list;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public int FuelcostsAdd(FuelModel vm)
        {
            string sql = "insert into fuel values (@fuelId,@plate_number,@cost,@oil_mass,@km,@pay,@broker,@comment,@creation_time)";
            int list = Dapper<FuelModel>.RUD(sql, vm);
            return list;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public int FuelcostsDel(int vehicleId)
        {
            string sql = "DELETE  from fuel where fuelId=@vehicleId";
            int list = Dapper<FuelModel>.RUD(sql, new { @vehicleId = vehicleId });
            return list;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public int FuelcostsEdit(FuelModel vm)
        {
            string sql = "update fuel set fuelId=@fuelId,plate_number=@plate_number,cost=@cost,oil_mass@oil_mass,km=@km,pay=@pay,broker=@broker,comment=@comment,creation_time=@creation_time where fuelId=@vehicleId";
            int list = Dapper<FuelModel>.RUD(sql, vm);
            return list;
        }
        /// <summary>
        /// 反添
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public FuelModel FuelcostsFt(int vehicleId)
        {
            string sql = "select * from fuel where fuelId=@vehicleId";
            FuelModel list = Dapper<FuelModel>.QueryFirst(sql, new { @vehicleId = vehicleId });
            return list;
        }

    }
}
