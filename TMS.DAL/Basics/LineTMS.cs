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
    public class LineTMS : TMSRepository<PathModel>, LineITMS
    {

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<PathModel> LineShow()
        {
            string sql = "select * from path";
            List<PathModel> list = Dapper<PathModel>.Query(sql);
            return list;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public int LineAdd(PathModel vm)
        {
            string sql = "insert into path values (@pathId,@path_Name,@origin,@origin_intro,@terminus,@terminus_intro,@isoutsource,@Name,@comment,@creation_time,@state,@phone,@unit)";
            int list = Dapper<PathModel>.RUD(sql, vm);
            return list;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public int LineDel(int vehicleId)
        {
            string sql = "DELETE  from path where pathId=@vehicleId";
            int list = Dapper<PathModel>.RUD(sql, new { @vehicleId = vehicleId });
            return list;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public int LineEdit(PathModel vm)
        {
            string sql = "update path set pathId=@pathId,path_Name=@path_Name,origin=@origin,origin_intro=@origin_intro,terminus=@terminus,terminus_intro=@terminus_intro,isoutsource=@isoutsource,Name=@Name,comment=@comment,creation_time=@creation_time,state=@state,phone=@phone,unit=@unit where pathId=@vehicleId";
            int list = Dapper<PathModel>.RUD(sql, vm);
            return list;
        }
        /// <summary>
        /// 反添
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public PathModel LineFt(int vehicleId)
        {
            string sql = "select * from path where pathId=@vehicleId";
            PathModel list = Dapper<PathModel>.QueryFirst(sql, new { @vehicleId = vehicleId });
            return list;
        }

    }
}
