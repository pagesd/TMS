using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS.IRepository;
using TMS.IRepository.Settlement;
using TMS.Model;
using TMS.Model.Settlement;

namespace TMS.Controllers
{
    /// <summary>
    /// 结算
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SettlementController : ControllerBase
    {

        ReceivableITMS dal;
        LnputinvoiceITMS dal_l;
        HandleITMS dal_h;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dal"></param>
        /// <param name="l_dal"></param>
        public SettlementController(ReceivableITMS _dal, LnputinvoiceITMS l_dal, HandleITMS h_dal)
        {
            dal = _dal;
            dal_l = l_dal;
            dal_h = h_dal;
        }

        #region//应收费用管理
        /// <summary>
        /// 应收费用显示
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
        /// 应收费用添加
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
        /// 应收费用反添
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
        /// 应收费用修改
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
        /// 应收费用删除
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
        /// 应收费用状态修改
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

        #region//进项费用管理
        /// <summary>
        /// 进项费用显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("LnputinvoiceShow")]
        public IActionResult LnputinvoiceShow()
        {
            try
            {
                int num;
                List<CourseModel> list = dal_l.LnputinvoiceShow();
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
        /// 进项费用添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("LnputinvoiceAdd")]
        public IActionResult LnputinvoiceAdd(CourseModel vm)
        {
            try
            {
                int list = dal_l.LnputinvoiceAdd(vm);
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
        /// 进项费用反添
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("Lnputinvoiceft")]
        public IActionResult Lnputinvoiceft(int id)
        {
            try
            {
                CourseModel list = dal_l.LnputinvoiceFt(id);
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
        /// 进项费用修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("LnputinvoiceEdit")]
        public IActionResult LnputinvoiceEdit(CourseModel vm)
        {
            try
            {
                int list = dal_l.LnputinvoiceEdit(vm);
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
        /// 进项费用删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("LnputinvoiceDel")]
        public IActionResult LnputinvoiceDel(int id)
        {
            try
            {
                int list = dal_l.LnputinvoiceDel(id);
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

        #region//付款费用管理
        /// <summary>
        /// 付款费用显示
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
        /// 付款费用添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("HandleAdd")]
        public IActionResult HandleAdd(PaymentModel vm)
        {
            try
            {
                int list = dal_h.HandleAdd(vm);
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
        /// 付款费用反添
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("Handleft")]
        public IActionResult Handleft(int id)
        {
            try
            {
                PaymentModel list = dal_h.HandleFt(id);
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
        /// 付款费用修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("HandleEdit")]
        public IActionResult HandleEdit(PaymentModel vm)
        {
            try
            {
                int list = dal_h.HandleEdit(vm);
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
        /// 付款费用删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("HandleDel")]
        public IActionResult HandleDel(int id)
        {
            try
            {
                int list = dal_h.HandleDel(id);
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
        /// 付款费用状态修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("HandleEdit1")]
        public IActionResult HandleEdit1(int id)
        {
            try
            {
                int list = dal_h.HandleEdit1(id);
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
