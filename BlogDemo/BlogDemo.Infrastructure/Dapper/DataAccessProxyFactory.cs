﻿
using System;

namespace BlogDemo.Infrastructure.Dapper
{
    public static class DataAccessProxyFactory
    {
        /// <summary>
        /// 创建数据库连接字符串
        /// </summary>
        /// <param name="cp"></param>
        /// <returns></returns>
        public static IDataAccess Create(ConnectionParameter cp)
        {
            if (string.IsNullOrEmpty(cp.ConnectionString))
            {
                throw new ArgumentNullException("ConnectionString is null or empty!");
            }
            return new DataAccess(cp.ConnectionString, cp.DataBaseType);
        }
    }

    /// <summary>
    /// 数据库连接配置
    /// </summary>
    public struct ConnectionParameter
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public DataBaseTypeEnum DataBaseType { get; set; }
    }
}