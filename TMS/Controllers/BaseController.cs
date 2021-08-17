using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS.IRepository;
using TMS.Model;
using TMS.Common;
using TMS.Repository;

namespace TMS.Controllers
{
    /// <summary>
    /// 基础
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        BaseITMS dal;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dal"></param>
        public BaseController(BaseITMS _dal) {
            dal = _dal;
        }

        /// <summary>
        /// 车辆显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("vehicleShow")]
        public IActionResult vehicleShow()
        {
            try
            {
                int num;
                List<VehicleModel> list = dal.Vehicle();
                if (list != null)
                {
                    return Ok(list);
                }
                else
                {
                    num = 2;
                    return Ok(num);
                }
            }
            catch (Exception)
            {

                return Ok("数据异常");
            }
        }
        /// <summary>
        /// 车辆添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("vehicleAdd")]
        public IActionResult vehicleAdd(VehicleModel vm)
        {
            try
            {
                int list = dal.VehicleAdd(vm);
                if (list!=0)
                {
                    return Ok("添加成功");
                }
                else
                {
                    return Ok("添加失败");
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //return Ok("数据异常");
            }
        }

        /// <summary>
        /// 车辆反添
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        [HttpPost, Route("vehicleft")]
        public IActionResult vehicleft(int vehicleId)
        { 
            try
            {
                VehicleModel list = dal.VehicleFt(vehicleId);
                if (list != null)
                {
                    return Ok(list);
                }
                else
                {
                    return Ok("数据为空/异常");
                }
            }
            catch (Exception)
            {

                return Ok("数据异常");
            }
        }
        /// <summary>
        /// 车辆修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("vehicleEdit")]
        public IActionResult vehicleEdit(VehicleModel vm)
        {
            try
            {
                int list = dal.VehicleEdit(vm);
                if (list!=0)
                {
                    return Ok("添加成功");
                }
                else
                {
                    return Ok("添加失败");
                }
            }
            catch (Exception ex) 
            {
                throw ex;
                //return Ok("数据异常");
            }
        }
        /// <summary>
        /// 车辆删除
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        [HttpPost, Route("vehicleDel")]
        public IActionResult vehicleDel(int vehicleId)
        {
            try
            {
                int list = dal.VehicleDel(vehicleId);
                if (list != 0)
                {
                    return Ok("删除成功");
                }
                else
                {
                    return Ok("删除失败");
                }
            }
            catch (Exception)
            {

                return Ok("数据异常");
            }
        }

    }
}
