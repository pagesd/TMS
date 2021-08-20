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
using TMS.JWT;

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
        public JWT_ _jwt;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dal"></param>
        /// <param name="wt_"></param>
        public LoginController(TMSILogi dal,JWT_ wt_)
        {
            _dal = dal;
            _jwt = wt_;
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
                
                UsersModel list = _dal.Login(admin, pwd);
                if (list != null)
                {
                    //登录成功
                    return Ok(new {data=list,token=_jwt.GetJWT() });
                }
                else
                {
                    //登录失败
                    return Ok("登录失败");
                }
                
            }
            catch (Exception)
            {
                return Ok("数据异常");
            }

        }

    }
}
