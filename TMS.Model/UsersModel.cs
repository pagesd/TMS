using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class UsersModel
    {
        public int usersId            { get; set; }     //主键
        public string pwd             { get; set; }     //密码
        public string admin           { get; set; }     //账号
        public string Name            { get; set; }     //姓名
        public int Sex                { get; set; }     //性别
        public string Phone           { get; set; }     //手机号
        public string academy         { get; set; }     //院校
        public string specialty       { get; set; }     //专业
        public string home            { get; set; }     //家庭住址
        public string politics_status { get; set; }     //政治面貌
        public string nation          { get; set; }     //民族
        public string native_place    { get; set; }     //籍贯
        public DateTime birthday      { get; set; }     //出生年月
        public string e_mail          { get; set; }     //邮箱
        public string identity_card   { get; set; }     //身份证
        public int education          { get; set; }     //学历
        public int marriage           { get; set; }     //婚姻
    }
}
