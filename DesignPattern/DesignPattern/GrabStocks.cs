using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class GrabStocks
    {
        static void Main(string[] args)
        {
            StockGrabber stockGrabber = new StockGrabber();

            var stockObserver1 = new StockObserver(stockGrabber);
            
            stockGrabber.setIbmPrice(197.00);
            stockGrabber.setaaplPrice(677.60);
            stockGrabber.setgoogPrice(676.40);

            var stockObserver2 = new StockObserver(stockGrabber);

            stockGrabber.setIbmPrice(97.00);
            stockGrabber.setaaplPrice(77.60);
            stockGrabber.setgoogPrice(76.40);


            stockGrabber.Unregister(stockObserver1);
        }
    }
}
