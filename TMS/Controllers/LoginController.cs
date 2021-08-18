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
    /// 登录
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        public TMSILogi _dal;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dal"></param>
        public LoginController(TMSILogi dal)
        {
            _dal = dal;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpPost,Route("Login2")]
        public IActionResult Login2(string admin = null, string pwd = null)
        {
            try
            {
                
                string num;
                UsersModel list = _dal.Login(admin, pwd);
                if (list != null)
                {
                    //登录成功
                    num = "登录成功";
                }
                else
                {
                    //登录失败
                    num = "登录失败";
                }
                return Ok(num);
            }
            catch (Exception)
            {
                return Ok("数据异常");
            }

        }

    }
}
