using System;
using Helper;
using Microsoft.Extensions.Options;
using SqlSugar;

namespace ProjectSqlSugar.ORM
{
    public class SqlSugarORM
    {
        public SqlSugarORM()
        {
        }
        /// <summary>
        /// 开启数据库连接
        /// </summary>
        /// <returns></returns>
        public static SqlSugarClient GetInstance()
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = AppsettingConfigs.GetAppsetting("ConnectionStrings:MSSqlConnection"),
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });

            return db;
        }
    }
}