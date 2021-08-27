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
    public class SettlementController : ControllerBase
    {

        ReceivableITMS dal;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dal"></param>
        public SettlementController(ReceivableITMS _dal)
        {
            dal = _dal;
        }

        #region//通用合同管理
        /// <summary>
        /// 通用合同显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("ReceivableShow")]
        public IActionResult ReceivableShow()
        {
            try
            {
                int num;
                List<ReceivableModel> list = dal.ReceivableShow();
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
        /// 通用添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("ReceivableAdd")]
        public IActionResult ReceivableAdd(ReceivableModel vm)
        {
            try
            {
                int list = dal.ReceivableAdd(vm);
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
        /// 通用反添
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("Receivableft")]
        public IActionResult Receivableft(int id)
        {
            try
            {
                ReceivableModel list = dal.ReceivableFt(id);
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
        /// 通用修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("ReceivableEdit")]
        public IActionResult ReceivableEdit(ReceivableModel vm)
        {
            try
            {
                int list = dal.ReceivableEdit(vm);
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
        /// 通用删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ReceivableDel")]
        public IActionResult ReceivableDel(int id)
        {
            try
            {
                int list = dal.ReceivableDel(id);
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
        /// 通用状态修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ReceivableEdit1")]
        public IActionResult ReceivableEdit1(int id)
        {
            try
            {
                int list = dal.ReceivableEdit1(id);
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
