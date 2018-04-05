using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public interface Observer
    {
        void update(double ibmPrice, double aaplPrice, double googPrice);
    }
}
