using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS.IRepository.Maintain;
using TMS.Model.Maintain;
using TMS.IRepository.Settlement;
using TMS.Model;
using TMS.Common;
using TMS.Repository;
using Microsoft.AspNetCore.Authorization;
using TMS.IRepository.Basics;


namespace TMS.Controllers
{
    /// <summary>
    /// 维护
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MaintainController : ControllerBase
    {
        RecordITMS dal;
        MaintenanceITMS dal_c;
        ViolationITMS dal_o;
        AccidentITMS dal_f;
        TireuseITMS dal_l;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dal"></param>
        /// <param name="c_dal"></param>
        /// <param name="o_dal"></param>
        /// <param name="f_dal"></param>
        /// <param name="l_dal"></param>
        public MaintainController(RecordITMS _dal, MaintenanceITMS c_dal, ViolationITMS o_dal, AccidentITMS f_dal, TireuseITMS l_dal)
        {
            dal = _dal;
            dal_c = c_dal;
            dal_o = o_dal;
            dal_f = f_dal;
            dal_l = l_dal;
        }

        #region//维修记录
        /// <summary>
        /// 维修记录显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("RecordShow"), Authorize]
        public IActionResult RecordShow()
        {
            try
            {
                int num;
                List<MaintainModel> list = dal.RecordShow();
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
        /// 维修记录添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("RecordAdd")]
        public IActionResult RecordAdd(MaintainModel vm)
        {
            try
            {
                int list = dal.RecordAdd(vm);
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
        /// 维修记录反添
        /// </summary>
        /// <param name="RecordId"></param>
        /// <returns></returns>
        [HttpPost, Route("Recordft")]
        public IActionResult Recordft(int RecordId)
        {
            try
            {
                MaintainModel list = dal.RecordFt(RecordId);
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
        /// 维修记录修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("RecordEdit")]
        public IActionResult RecordEdit(MaintainModel vm)
        {
            try
            {
                int list = dal.RecordEdit(vm);
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
        /// 维修记录删除
        /// </summary>
        /// <param name="RecordId"></param>
        /// <returns></returns>
        [HttpPost, Route("RecordDel")]
        public IActionResult RecordDel(int RecordId)
        {
            try
            {
                int list = dal.RecordDel(RecordId);
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

        #region//保养记录
        /// <summary>
        /// 保养记录显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("MaintenanceShow"), Authorize]
        public IActionResult MaintenanceShow()
        {
            try
            {
                int num;
                List<UpkeepModel> list = dal_c.MaintenanceShow();
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
        /// 保养记录添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("MaintenanceAdd")]
        public IActionResult MaintenanceAdd(UpkeepModel vm)
        {
            try
            {
                int list = dal_c.MaintenanceAdd(vm);
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
        /// 保养记录反添
        /// </summary>
        /// <param name="RecordId"></param>
        /// <returns></returns>
        [HttpPost, Route("Maintenanceft")]
        public IActionResult Maintenanceft(int RecordId)
        {
            try
            {
                UpkeepModel list = dal_c.MaintenanceFt(RecordId);
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
        /// 保养记录修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("MaintenanceEdit")]
        public IActionResult MaintenanceEdit(UpkeepModel vm)
        {
            try
            {
                int list = dal_c.MaintenanceEdit(vm);
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
        /// 保养记录删除
        /// </summary>
        /// <param name="RecordId"></param>
        /// <returns></returns>
        [HttpPost, Route("MaintenanceDel")]
        public IActionResult MaintenanceDel(int RecordId)
        {
            try
            {
                int list = dal_c.MaintenanceDel(RecordId);
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

        #region//违章记录
        /// <summary>
        /// 违章记录显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("ViolationShow"), Authorize]
        public IActionResult ViolationShow()
        {
            try
            {
                int num;
                List<ViolationModel> list = dal_o.ViolationShow();
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
        /// 违章记录添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("ViolationAdd")]
        public IActionResult ViolationAdd(ViolationModel vm)
        {
            try
            {
                int list = dal_o.ViolationAdd(vm);
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
        /// 违章记录反添
        /// </summary>
        /// <param name="RecordId"></param>
        /// <returns></returns>
        [HttpPost, Route("Violationft")]
        public IActionResult Violationft(int RecordId)
        {
            try
            {
                ViolationModel list = dal_o.ViolationFt(RecordId);
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
        /// 违章记录修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("ViolationEdit")]
        public IActionResult ViolationEdit(ViolationModel vm)
        {
            try
            {
                int list = dal_o.ViolationEdit(vm);
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
        /// 违章记录删除
        /// </summary>
        /// <param name="RecordId"></param>
        /// <returns></returns>
        [HttpPost, Route("ViolationDel")]
        public IActionResult ViolationDel(int RecordId)
        {
            try
            {
                int list = dal_o.ViolationDel(RecordId);
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

        #region//事故记录
        /// <summary>
        /// 事故记录显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("AccidentShow"), Authorize]
        public IActionResult AccidentShow()
        {
            try
            {
                int num;
                List<AccidentModel> list = dal_f.AccidentShow();
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
        /// 事故记录添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("AccidentAdd")]
        public IActionResult AccidentAdd(AccidentModel vm)
        {
            try
            {
                int list = dal_f.AccidentAdd(vm);
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
        /// 事故记录反添
        /// </summary>
        /// <param name="RecordId"></param>
        /// <returns></returns>
        [HttpPost, Route("Accidentft")]
        public IActionResult Accidentft(int RecordId)
        {
            try
            {
                AccidentModel list = dal_f.AccidentFt(RecordId);
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
        /// 事故记录修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("AccidentEdit")]
        public IActionResult AccidentEdit(AccidentModel vm)
        {
            try
            {
                int list = dal_f.AccidentEdit(vm);
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
        /// 事故记录删除
        /// </summary>
        /// <param name="RecordId"></param>
        /// <returns></returns>
        [HttpPost, Route("AccidentDel")]
        public IActionResult AccidentDel(int RecordId)
        {
            try
            {
                int list = dal_f.AccidentDel(RecordId);
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

        #region//轮胎使用记录
        /// <summary>
        /// 轮胎使用记录显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("TireuseShow"), Authorize]
        public IActionResult TireuseShow()
        {
            try
            {
                int num;
                List<TyreModel> list = dal_l.TireuseShow();
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
        /// 轮胎使用记录添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("TireuseAdd")]
        public IActionResult TireuseAdd(TyreModel vm)
        {
            try
            {
                int list = dal_l.TireuseAdd(vm);
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
        /// 轮胎使用记录反添
        /// </summary>
        /// <param name="RecordId"></param>
        /// <returns></returns>
        [HttpPost, Route("Tireuseft")]
        public IActionResult Tireuseft(int RecordId)
        {
            try
            {
                TyreModel list = dal_l.TireuseFt(RecordId);
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
        /// 轮胎使用记录修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("TireuseEdit")]
        public IActionResult TireuseEdit(TyreModel vm)
        {
            try
            {
                int list = dal_l.TireuseEdit(vm);
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
        /// 轮胎使用记录删除
        /// </summary>
        /// <param name="RecordId"></param>
        /// <returns></returns>
        [HttpPost, Route("TireuseDel")]
        public IActionResult TireuseDel(int RecordId)
        {
            try
            {
                int list = dal_l.TireuseDel(RecordId);
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
