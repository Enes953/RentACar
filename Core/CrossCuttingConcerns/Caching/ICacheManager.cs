﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Caching
{
    public interface ICacheManager
    {
        //key,value atanır. 
        //Cache ne işe yarar? Sen bir datayı getirdiğinde sürekli çağırdıgında veritabanına gitmeden cagırır hep
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value, int duration);
        bool IsAdd(string key);
        void Remove(string key);
        
        void RemoveByPattern(string pattern);
    }
}
