using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using Helper;
using ProjectSqlSugar.ORM;

namespace ProjectSqlSugar.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController()
        {

        }

        /// <summary>
        /// 数据库连接测试
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetDbConn()
        {
            var db = SqlSugarORM.GetInstance();
            //通过库生成实体
            //db.DbFirst.CreateClassFile("D:\\Documents\\GitHub\\ProjectSqlSugar\\ProjectSqlSugar.ORM\\DbModel");
            Models.User insert_User = new Models.User()
            {
                User_Mobile = "17089791398",
                User_NickName = "刘志恒"
            };

            int insert_Row = db.Insertable(insert_User).Where(true).ExecuteCommand();
            //int insert_Row = db.Ado.ExecuteCommand("INSERT INTO User (User_Mobile,User_NickName) VALUES (@user_Mobile,@user_NickName) ", new { user_Mobile = "13783471301", user_NickName = "echo" });

            return "Success";
        }
    }
}