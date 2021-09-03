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
    /// 基础   外协
    /// </summary>
    public class OutsourcingTMS : TMSRepository<OutsourceModel>, OutsourcingITMS
    {

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<OutsourceModel> OutsourcingShow()
        {
            string sql = "select * from outsource";
            List<OutsourceModel> list = Dapper<OutsourceModel>.Query(sql);
            return list;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public int OutsourcingAdd(OutsourceModel vm)
        {
            string sql = "insert into outsource values (@outsourceId,@unit_Name,@email,@fixed_line,@phone,@site,@creation_time,@comment)";
            int list = Dapper<OutsourceModel>.RUD(sql, vm);
            return list;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public int OutsourcingDel(int vehicleId)
        {
            string sql = "DELETE  from outsource where outsourceId=@vehicleId";
            int list = Dapper<OutsourceModel>.RUD(sql, new { @vehicleId = vehicleId });
            return list;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public int OutsourcingEdit(OutsourceModel vm)
        {
            string sql = "update outsource set outsourceId=@outsourceId,unit_Name=@unit_Name,email=@email,fixed_line=@fixed_line,phone=@phone,site=@site,creation_time=@creation_time,comment=@comment where outsourceId=@vehicleId";
            int list = Dapper<OutsourceModel>.RUD(sql, vm);
            return list;
        }
        /// <summary>
        /// 反添
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public OutsourceModel OutsourcingFt(int id)
        {
            string sql = "select * from outsource where outsourceId=@id";
            OutsourceModel list = Dapper<OutsourceModel>.QueryFirst(sql, new { @id = id });
            return list;
        }

    }
}
