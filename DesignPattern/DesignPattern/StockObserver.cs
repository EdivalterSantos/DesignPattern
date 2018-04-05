
using System.Diagnostics;

namespace DesignPattern
{
    class StockObserver : Observer
    {
        private double ibmPrice;
        private double aaplPrice;
        private double googPrice;
        private int observerId;
        private static int observerIDTracker = 0;

        public Subject StockGrabber { get; set; }

        public StockObserver(Subject stockGrabber)
        {
            StockGrabber = stockGrabber;
            observerId = ++observerIDTracker;
            Debug.WriteLine("New Observer" + observerId);
            stockGrabber.register(this);
        }
        public void update(double ibmPrice, double aaplPrice, double googPrice)
        {
            this.ibmPrice = ibmPrice;
            this.aaplPrice = aaplPrice;
            this.googPrice = googPrice;

            printThePrices();
        }

        public void printThePrices()
        {
            Debug.WriteLine(observerId + "\nIBM " + ibmPrice + "\nAAPL "
                                       + aaplPrice + "\nGOOG " + googPrice);
        }
    }
}
