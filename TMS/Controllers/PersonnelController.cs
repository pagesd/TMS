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
    /// 人事
    /// </summary>
    public class PersonnelController : Controller
    {
        StaffITMS dal;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dal"></param>
        public PersonnelController(StaffITMS _dal)
        {
            dal = _dal;
        }

        #region//员工登记
        /// <summary>
        /// 人事显示
        /// </summary>
        /// <returns></returns>
        [HttpPost, Route("StaffShow")]
        public IActionResult StaffShow()
        {
            try
            {
                int num;
                List<StaffModel> list = dal.StaffShow();
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
        /// 人事添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("vehicleAdd")]
        public IActionResult StaffAdd(StaffModel vm)
        {
            try
            {
                vm.create_time = DateTime.Now;
                int list = dal.StaffAdd(vm);
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
        /// 人事反添
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("StaffFt")]
        public IActionResult StaffFt(int id)
        {
            try
            {
                StaffModel list = dal.StaffFt(id);
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
        /// 人事修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("StaffEdit")]
        public IActionResult StaffEdit(StaffModel vm)
        {
            try
            {
                int list = dal.StaffEdit(vm);
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
        /// 人事删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("StaffDel")]
        public IActionResult StaffDel(int id)
        {
            try
            {
                int list = dal.StaffDel(id);
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
