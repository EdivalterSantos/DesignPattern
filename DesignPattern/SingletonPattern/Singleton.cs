using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton _firstInstance = null;

        private Singleton() { }

        public static Singleton getInstance()
        {
            if (_firstInstance == null)
            {
                _firstInstance = new Singleton();
            }

            return _firstInstance;
        }

    }
}
