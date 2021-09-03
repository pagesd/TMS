using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS.IRepository;
using TMS.Model;
using TMS.IRepository.Settlement;
using TMS.Model.Settlement;

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
        HandleITMS dal_h;
        UniversalITMS dal_u;
        /// <summary>
        /// 通用合同
        /// </summary>
        /// <param name="_dal"></param>
        public ApproveController(CarriageITMS _dal,HandleITMS h_dal, UniversalITMS u_dal)
        {
            dal = _dal;
            dal_h = h_dal;
            dal_u = u_dal;
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
        /// 承运显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("CarriageShow")]
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
        /// 承运审核成功
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("CarriageEditTG")]
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
        /// 承运审核失败
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("CarriageEditJJ")]
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

        #region//付款审核
        /// <summary>
        /// 付款显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("HandleShow")]
        public IActionResult HandleShow()
        {
            try
            {
                int num;
                List<PaymentModel> list = dal_h.HandleShow();
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
        /// 付款审核成功
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("HandleEditTG")]
        public IActionResult HandleEditTG(int id)
        {
            try
            {
                int list = dal_h.HandleEditTG(id);
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
        /// 付款审核失败
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("HandleEditJJ")]
        public IActionResult HandleEditJJ(int id)
        {
            try
            {
                int list = dal_h.HandleEditJJ(id);
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

        #region//通用合同审核
        /// <summary>
        /// 通用合同显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("UniversalShow")]
        public IActionResult UniversalShow()
        {
            try
            {
                int num;
                List<UniversalModel> list = dal_u.UniversalShow();
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
        /// 通用合同审核成功
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("UniversalEditTG")]
        public IActionResult UniversalEditTG(int id)
        {
            try
            {
                int list = dal_u.UniversalEditTG(id);
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
        /// 通用合同审核失败
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("UniversalEditJJ")]
        public IActionResult UniversalEditJJ(int id)
        {
            try
            {
                int list = dal_u.UniversalEditJJ(id);
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
