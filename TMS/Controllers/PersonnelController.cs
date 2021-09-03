using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS.IRepository;
using TMS.Model;
using TMS.Common;


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
        /// 员工登记显示
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
        /// 员工登记添加
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
        /// 员工登记反添
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
        /// 员工登记修改
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
        /// 员工登记删除
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

        #region//入职办理
        /// <summary>
        /// 入职办理显示
        /// </summary>
        /// <returns></returns>
        [HttpPost, Route("OnboardingShow")]
        public IActionResult OnboardingShow()
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
        /// 入职办理添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("OnboardingAdd")]
        public IActionResult OnboardingAdd(StaffModel vm)
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
        /// 入职办理反添
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("OnboardingFt")]
        public IActionResult OnboardingFt(int id)
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
        /// 入职办理修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("OnboardingEdit")]
        public IActionResult OnboardingEdit(StaffModel vm)
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
        /// 入职办理删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("OnboardingDel")]
        public IActionResult OnboardingDel(int id)
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

        #region//离职办理
        /// <summary>
        /// 离职办理显示
        /// </summary>
        /// <returns></returns>
        [HttpPost, Route("ResignShow")]
        public IActionResult ResignShow()
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
        /// 离职办理添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("ResignAdd")]
        public IActionResult ResignAdd(StaffModel vm)
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
        /// 离职办理反添
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ResignFt")]
        public IActionResult ResignFt(int id)
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
        /// 离职办理修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("ResignEdit")]
        public IActionResult ResignEdit(StaffModel vm)
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
        /// 离职办理删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("ResignDel")]
        public IActionResult ResignDel(int id)
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

        #region//转正办理
        /// <summary>
        /// 转正办理显示
        /// </summary>
        /// <returns></returns>
        [HttpPost, Route("TurnpositiveShow")]
        public IActionResult TurnpositiveShow()
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
        /// 转正办理添加
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("TurnpositiveAdd")]
        public IActionResult TurnpositiveAdd(StaffModel vm)
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
        /// 转正办理反添
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("TurnpositiveFt")]
        public IActionResult TurnpositiveFt(int id)
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
        /// 转正办理修改
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost, Route("TurnpositiveEdit")]
        public IActionResult TurnpositiveEdit(StaffModel vm)
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
        /// 转正办理删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("TurnpositiveDel")]
        public IActionResult TurnpositiveDel(int id)
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
