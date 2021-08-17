using System;
using System.Collections.Generic;

namespace TMS.IRepository
{
    public interface TMSIRepository<T> where T : class, new()
    {
        //显示
        List<T> Show(string sql, object pat = null);
        //增删改
        int ZSG(string sql, object pat = null);
    }
}
