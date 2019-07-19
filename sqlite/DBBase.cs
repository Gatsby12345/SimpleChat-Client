using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChat.data
{
    public class DBBase
    {
        public static string connStr = @"Data Source=" + System.Environment.CurrentDirectory + @"\wechat.db3;Initial Catalog=sqlite;Integrated Security=True;Max Pool Size=10";
    }
}
