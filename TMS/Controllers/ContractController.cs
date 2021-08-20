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
    /// 合同
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        /// <summary>
        /// //承运/货主
        /// </summary>
        CarriageITMS dal;
        /// <summary>
        /// 通用合同
        /// </summary>
        /// <param name="_dal"></param>
        public ContractController(CarriageITMS _dal)
        {
            dal = _dal;
        }


        #region//货主合同管理
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
        /// 货主添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("ConsignorAdd")]
        public IActionResult ConsignorAdd(CarriagecontractModel vm)
        {
            try
            {
                vm.contractId = "H" + DateTime.Now.ToString("yyyyMMddhhmm");
                vm.creation_time = DateTime.Now;
                vm.state = 0;
                vm.approval = "-";
                vm.zt = 1;
                int list = dal.ConsignorAdd(vm);
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
        [HttpPost, Route("Consignorft")]
        public IActionResult Consignorft(int vehicleId)
        {
            try
            {
                CarriagecontractModel list = dal.ConsignorFt(vehicleId);
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
        [HttpPost, Route("ConsignorEdit")]
        public IActionResult ConsignorEdit(CarriagecontractModel vm)
        {
            try
            {
                int list = dal.ConsignorEdit(vm);
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
        /// 货主删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ConsignorDel")]
        public IActionResult ConsignorDel(int id)
        {
            try
            {
                int list = dal.ConsignorDel(id);
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
        /// 货主状态修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ConsignorEdit1")]
        public IActionResult ConsignorEdit1(int id)
        {
            try
            {
                int list = dal.ConsignorEdit1(id);
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

        #region//承运合同管理
        /// <summary>
        /// 承运显示
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost, Route("ContractShow")]
        public IActionResult ContractShow()
        {
            try
            {
                int num;
                List<CarriagecontractModel> list = dal.CarriageShow();
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
        /// 承运添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("ContractAdd")]
        public IActionResult ContractAdd(CarriagecontractModel vm)
        {
            try
            {
                vm.contractId = "H" + DateTime.Now.ToString("yyyyMMddhhmm");
                vm.creation_time = DateTime.Now;
                vm.state = 0;
                vm.approval = "-";
                vm.zt=2;
                int list = dal.CarriageAdd(vm);
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
        /// 承运反添
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        [HttpPost, Route("Contractft")]
        public IActionResult Contractft(int vehicleId)
        {
            try
            {
                CarriagecontractModel list = dal.CarriageFt(vehicleId);
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
        /// 承运修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("ContractEdit")]
        public IActionResult ContractEdit(CarriagecontractModel vm)
        {
            try
            {
                int list = dal.CarriageEdit(vm);
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
        /// 承运删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ContractDel")]
        public IActionResult ContractDel(int id)
        {
            try
            {
                int list = dal.CarriageDel(id);
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
        /// 承运状态修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ContractEdit1")]
        public IActionResult ContractEdit1(int id)
        {
            try
            {
                int list = dal.CarriageEdit1(id);
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
