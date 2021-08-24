using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS.IRepository;
using TMS.Model;

namespace TMS.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ReceivingController : ControllerBase
    {
        /// <summary>
        /// 物资领用
        /// </summary>
        ReceivingITMS dal;
        /// <summary>
        /// 物资领用
        /// </summary>
        /// <param name="_dal"></param>
        public ReceivingController(ReceivingITMS _dal)
        {
            dal = _dal;
        }

        #region//物资领用
        /// <summary>
        /// 显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("ReceivingShow")]
        public IActionResult ReceivingShow()
        {
            try
            {
                int num;
                List<ReceivingModel> list = dal.ReceivingShow();
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
        /// 添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("ReceivingAdd")]
        public IActionResult ReceivingAdd(ReceivingModel vm)
        {
            try
            {
                //默认审批状态为0(未审批)
                vm.state = 0;
                //审批人为-
                vm.approver = "-";
                //创建时间
                vm.create_time = DateTime.Now;
                int list = dal.ReceivingAdd(vm);
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
        /// 反添
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ReceivingFt")]
        public IActionResult ReceivingFt(int id)
        {
            try
            {
                ReceivingModel list = dal.ReceivingFt(id);
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
        /// 修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("ReceivingEdit")]
        public IActionResult ReceivingEdit(ReceivingModel vm)
        {
            try
            {
                int list = dal.ReceivingEdit(vm);
                if (list != 0)
                {
                    return Ok("修改成功");
                }
                else
                {
                    return Ok("修改失败");
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //return Ok("数据异常");
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ReceivingDel")]
        public IActionResult ReceivingDel(int id)
        {
            try
            {
                int list = dal.ReceivingDel(id);
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

        /// <summary>
        /// 状态修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ReceivingEdit1")]
        public IActionResult ReceivingEdit1(int id)
        {
            try
            {
                int list = dal.ReceivingEdit1(id);
                if (list != 0)
                {
                    return Ok("修改成功");
                }
                else
                {
                    return Ok("修改失败");
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //return Ok("数据异常");
            }
        }

        #endregion


    }
}
