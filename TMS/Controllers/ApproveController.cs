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
    /// 审批
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ApproveController : ControllerBase
    {

        /// <summary>
        /// //承运/货主
        /// </summary>
        CarriageITMS dal;
        /// <summary>
        /// 通用合同
        /// </summary>
        /// <param name="_dal"></param>
        public ApproveController(CarriageITMS _dal)
        {
            dal = _dal;
        }

        #region//货主审核
        /// <summary>
        /// 货主显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("ConsignorShow")]
        public IActionResult ConsignorShow()
        {
            try
            {
                int num;
                List<CarriagecontractModel> list = dal.ConsignorShow();
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
        /// 货主审核成功
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ConsignorEditTG")]
        public IActionResult ConsignorEditTG(int id)
        {
            try
            {
                int list = dal.ConsignorEditTG(id);
                if (list != 0)
                {
                    return Ok("审核通过");
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
        /// 货主审核失败
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ConsignorEditJJ")]
        public IActionResult ConsignorEditJJ(int id)
        {
            try
            {
                int list = dal.ConsignorEditJJ(id);
                if (list != 0)
                {
                    return Ok("拒绝审核");
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

        #region//承运审核
        /// <summary>
        /// 货主显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("ConsignorShow")]
        public IActionResult CarriageShow()
        {
            try
            {
                int num;
                List<CarriagecontractModel> list = dal.ConsignorShow();
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
        /// 货主审核成功
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ConsignorEditTG")]
        public IActionResult CarriageEditTG(int id)
        {
            try
            {
                int list = dal.ConsignorEditTG(id);
                if (list != 0)
                {
                    return Ok("审核通过");
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
        /// 货主审核失败
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ConsignorEditJJ")]
        public IActionResult CarriageEditJJ(int id)
        {
            try
            {
                int list = dal.ConsignorEditJJ(id);
                if (list != 0)
                {
                    return Ok("拒绝审核");
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
