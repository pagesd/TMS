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
    /// 菜单管理
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class JurisdictionController : ControllerBase
    {

        /// <summary>
        /// 
        /// </summary>
        public JurisdictionITMS _dal;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dal"></param>
        public JurisdictionController(JurisdictionITMS dal)
        {
            _dal = dal;
        }

        /// <summary>
        /// 权限查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("Useer")]
        public IActionResult Useer(int id)
        {
            try
            {
                int num;
                List<MenuModel> list = _dal.Use(id);
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
        /// 二级菜单查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("User2")]
        public IActionResult User2(int id)
        {
            try
            {
                int num;
                List<MenuModel> list = _dal.Use2(id);
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
