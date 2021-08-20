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
    /// 通用合同
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UniversalController : ControllerBase
    {

        UniversalITMS dal;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dal"></param>
        public UniversalController(UniversalITMS _dal)
        {
            dal = _dal;
        }

        #region//通用合同管理
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
                List<UniversalModel> list = dal.UniversalShow();
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
        [HttpPost, Route("UniversalAdd")]
        public IActionResult UniversalAdd(UniversalModel vm)
        {
            try
            {
                vm.contracId = "CY" + DateTime.Now.ToString("yyyyMMddhhmm");
                vm.creation_time = DateTime.Now;
                vm.state = 0;
                vm.approver = "-";
                int list = dal.UniversalAdd(vm);
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
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        [HttpPost, Route("Universalft")]
        public IActionResult Universalft(int vehicleId)
        {
            try
            {
                UniversalModel list = dal.UniversalFt(vehicleId);
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
        [HttpPost, Route("UniversalEdit")]
        public IActionResult UniversalEdit(UniversalModel vm)
        {
            try
            {
                int list = dal.UniversalEdit(vm);
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
        [HttpPost, Route("UniversalDel")]
        public IActionResult UniversalDel(int id)
        {
            try
            {
                int list = dal.UniversalDel(id);
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
        [HttpPost, Route("UniversalEdit1")]
        public IActionResult UniversalEdit1(int id)
        {
            try
            {
                int list = dal.UniversalEdit1(id);
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
