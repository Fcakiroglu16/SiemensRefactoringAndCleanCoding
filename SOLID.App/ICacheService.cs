using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.App
{
    internal class RedisCacheService : ICacheService
    {
        public void Add(string key, object value, int duration)
        {
        }

        public T Get<T>(string key)
        {
            var data = new object();
            return (T)data;
        }

        public bool IsAdd(string key)
        {
            return true;
        }

        public void Remove(string key)
        {
        }
    }
}

namespace SOLID.App
{
    internal interface ICacheService
    {
        void Add(string key, object value, int duration);
        T Get<T>(string key);
        bool IsAdd(string key);
        void Remove(string key);
    }
}