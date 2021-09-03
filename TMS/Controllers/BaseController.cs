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
using Microsoft.AspNetCore.Authorization;
using TMS.IRepository.Basics;

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
        CargoownerITMS dal_c;
        OutsourcingITMS dal_o;
        FuelcostsITMS dal_f;
        LineITMS dal_l;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dal"></param>
        /// <param name="c_dal"></param>
        /// <param name="o_dal"></param>
        /// <param name="f_dal"></param>
        /// <param name="l_dal"></param>
        public BaseController(BaseITMS _dal,CargoownerITMS c_dal, OutsourcingITMS o_dal, FuelcostsITMS f_dal, LineITMS l_dal) {
            dal = _dal;
            dal_c = c_dal;
            dal_o = o_dal;
            dal_f = f_dal;
            dal_l = l_dal;
        }

        #region//车辆管理
        /// <summary>
        /// 车辆显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("vehicleShow"), Authorize]
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
        #endregion

        #region//货主管理
        /// <summary>
        /// 货主显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("CargoownerShow"), Authorize]
        public IActionResult CargoownerShow()
        {
            try
            {
                int num;
                List<ShipperModel> list = dal_c.CargoownerShow();
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
        /// 货主添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("CargoownerAdd")]
        public IActionResult CargoownerAdd(ShipperModel vm)
        {
            try
            {
                int list = dal_c.CargoownerAdd(vm);
                if (list != 0)
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
        /// 货主反添
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        [HttpPost, Route("CargoownerFt")]
        public IActionResult CargoownerFt(int vehicleId)
        {
            try
            {
                ShipperModel list = dal_c.CargoownerFt(vehicleId);
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
        /// 货主修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("CargoownerEdit")]
        public IActionResult CargoownerEdit(ShipperModel vm)
        {
            try
            {
                int list = dal_c.CargoownerEdit(vm);
                if (list != 0)
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
        /// 货主删除
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        [HttpPost, Route("CargoownerDel")]
        public IActionResult CargoownerDel(int vehicleId)
        {
            try
            {
                int list = dal_c.CargoownerDel(vehicleId);
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
        #endregion

        #region//外协管理
        /// <summary>
        /// 货主显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("OutsourcingShow"), Authorize]
        public IActionResult OutsourcingShow()
        {
            try
            {
                int num;
                List<OutsourceModel> list = dal_o.OutsourcingShow();
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
        /// 外协添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("OutsourcingAdd")]
        public IActionResult OutsourcingAdd(OutsourceModel vm)
        {
            try
            {
                int list = dal_o.OutsourcingAdd(vm);
                if (list != 0)
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
        /// 外协反添
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        [HttpPost, Route("OutsourcingFt")]
        public IActionResult OutsourcingFt(int vehicleId)
        {
            try
            {
                OutsourceModel list = dal_o.OutsourcingFt(vehicleId);
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
        /// 外协修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("OutsourcingEdit")]
        public IActionResult OutsourcingEdit(OutsourceModel vm)
        {
            try
            {
                int list = dal_o.OutsourcingEdit(vm);
                if (list != 0)
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
        /// 外协删除
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        [HttpPost, Route("OutsourcingDel")]
        public IActionResult OutsourcingDel(int vehicleId)
        {
            try
            {
                int list = dal_o.OutsourcingDel(vehicleId);
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
        #endregion

        #region//油费管理
        /// <summary>
        /// 油费显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("FuelcostsShow"), Authorize]
        public IActionResult FuelcostsShow()
        {
            try
            {
                int num;
                List<FuelModel> list = dal_f.FuelcostsShow();
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
        /// 油费添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("FuelcostsAdd")]
        public IActionResult FuelcostsAdd(FuelModel vm)
        {
            try
            {
                int list = dal_f.FuelcostsAdd(vm);
                if (list != 0)
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
        /// 油费反添
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        [HttpPost, Route("FuelcostsFt")]
        public IActionResult FuelcostsFt(int vehicleId)
        {
            try
            {
                FuelModel list = dal_f.FuelcostsFt(vehicleId);
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
        /// 油费修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("FuelcostsEdit")]
        public IActionResult FuelcostsEdit(FuelModel vm)
        {
            try
            {
                int list = dal_f.FuelcostsEdit(vm);
                if (list != 0)
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
        /// 油费删除
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        [HttpPost, Route("FuelcostsDel")]
        public IActionResult FuelcostsDel(int vehicleId)
        {
            try
            {
                int list = dal_f.FuelcostsDel(vehicleId);
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
        #endregion

        #region//线路管理
        /// <summary>
        /// 线路显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("LineShow"), Authorize]
        public IActionResult LineShow()
        {
            try
            {
                int num;
                List<PathModel> list = dal_l.LineShow();
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
        /// 线路添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("LineAdd")]
        public IActionResult LineAdd(PathModel vm)
        {
            try
            {
                int list = dal_l.LineAdd(vm);
                if (list != 0)
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
        /// 线路反添
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        [HttpPost, Route("LineFt")]
        public IActionResult LineFt(int vehicleId)
        {
            try
            {
                PathModel list = dal_l.LineFt(vehicleId);
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
        /// 线路修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("LineEdit")]
        public IActionResult LineEdit(PathModel vm)
        {
            try
            {
                int list = dal_l.LineEdit(vm);
                if (list != 0)
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
        /// 线路删除
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        [HttpPost, Route("LineDel")]
        public IActionResult LineDel(int vehicleId)
        {
            try
            {
                int list = dal_l.LineDel(vehicleId);
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
        #endregion


    }
}
