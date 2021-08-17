using System;
using Dapper;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using TMS.IRepository;
using System.Collections.Generic;
using TMS.Common;
using DataCommon;

namespace TMS.Repository
{
    public class TMSRepository<T> : TMSIRepository<T> where T : class, new()
    {
        public List<T> Show(string sql, object pat = null)
        {
            List<T> data = Dapper<T>.Query(sql, pat);
            return data;
        }

        public int ZSG(string sql, object pat = null)
        {
            int i = Dapper<T>.RUD(sql, pat);
            return i;
        }
    }
}
