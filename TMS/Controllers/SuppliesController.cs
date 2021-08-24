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
    /// 物资
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliesController : ControllerBase
    {

        /// <summary>
        /// 物资
        /// </summary>
        SuppliesITMS dal;
        /// <summary>
        /// 物资
        /// </summary>
        /// <param name="_dal"></param>
        public SuppliesController(SuppliesITMS _dal)
        {
            dal = _dal;
        }

        #region//物资采购
        /// <summary>
        /// 显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("PurchaseShow")]
        public IActionResult PurchaseShow()
        {
            try
            {
                int num;
                List<PurchaseModel> list = dal.PurchaseShow();
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
        [HttpPost, Route("PurchaseAdd")]
        public IActionResult PurchaseAdd(PurchaseModel vm)
        {
            try
            {
                //默认审批状态为0(未审批)
                vm.state = 0;
                //审批人为-
                vm.approver = "-";
                //创建时间
                vm.create_time = DateTime.Now;
                int list = dal.PurchaseAdd(vm);
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
        [HttpPost, Route("PurchaseFt")]
        public IActionResult PurchaseFt(int id)
        {
            try
            {
                PurchaseModel list = dal.PurchaseFt(id);
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
        [HttpPost, Route("PurchaseEdit")]
        public IActionResult PurchaseEdit(PurchaseModel vm)
        {
            try
            {
                int list = dal.PurchaseEdit(vm);
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
        [HttpPost, Route("PurchaseDel")]
        public IActionResult PurchaseDel(int id)
        {
            try
            {
                int list = dal.PurchaseDel(id);
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
        [HttpPost, Route("PurchaseEdit1")]
        public IActionResult PurchaseEdit1(int id)
        {
            try
            {
                int list = dal.PurchaseEdit1(id);
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

        /// <summary>
        /// 入库修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("WarehousingEdit")]
        public IActionResult WarehousingEdit(PurchaseModel vm)
        {
            try
            {
                int list = dal.WarehousingEdit(vm);
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
        /// 显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("WarehousingShow")]
        public IActionResult WarehousingShow()
        {
            try
            {
                int num;
                List<PurchaseModel> list = dal.WarehousingShow();
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

    }
}
