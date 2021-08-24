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
using Microsoft.Extensions.Logging;

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
        /// 日志器
        /// </summary>
        private ILogger m_logger;
        /// <summary>
        /// 日志器工厂
        /// </summary>
        private ILoggerFactory m_LoggerFactory;


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
        public LoginController(TMSILogi dal,JWT_ wt_, ILoggerFactory loggerFactory)
        {
            _dal = dal;
            _jwt = wt_;

            m_LoggerFactory = loggerFactory;
            // 获取指定名字的日志器
            m_logger = m_LoggerFactory.CreateLogger("AppLogger");
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
            catch (Exception ex)
            {
                m_logger.LogError(ex, "捕捉到异常");
                return Ok("数据异常");
            }

        }

    }
}
