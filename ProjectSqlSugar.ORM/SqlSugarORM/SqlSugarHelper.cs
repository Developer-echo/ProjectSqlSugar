using System;
using SqlSugar;

namespace ProjectSqlSugar.ORM
{
    public class SqlSugarHelper
    {
        public static SqlSugarClient GetInstance()
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "",
                DbType = DbType.MySql,
                InitKeyType = InitKeyType.Attribute
            });

            return db;
        }

        #region 可以写一些自定义的操作方法
        #endregion
    }
}