using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern
{
    public interface Subject
    {
        void register(Observer o);
        void Unregister(Observer o);
        void NotifyObserver();
    }
}
