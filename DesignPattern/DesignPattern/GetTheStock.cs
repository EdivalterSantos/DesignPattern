using System;
using System.Threading.Tasks;

namespace DesignPattern
{
    class GetTheStock : Task
    {


        public GetTheStock(Action action) : base(action)
        {
        }
    }
}
