using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class StockGrabber : Subject
    {
        private List<Observer> observers;
        private double ibmPrice;
        private double aaplPrice;
        private double googPrice;

        public StockGrabber()
        {
            observers = new List<Observer>();
        }

        public void register(Observer newObserver)
        {
            observers.Add(newObserver);

        }

        public void Unregister(Observer deleteObserver)
        {
            int observerIndex = observers.IndexOf(deleteObserver);

            Debug.WriteLine("Observer" + (observerIndex + 1) + " Deleted");

            observers.Remove(deleteObserver);

        }

        public void NotifyObserver()
        {
            foreach (Observer observer in observers)
            {
                observer.update(ibmPrice, aaplPrice, googPrice);
            }
        }


        public void setIbmPrice(double newIbmPrice)
        {
            ibmPrice = newIbmPrice;
            NotifyObserver();
        }

        public void setaaplPrice(double newaaplPrice)
        {
            aaplPrice = newaaplPrice;
            NotifyObserver();
        }

        public void setgoogPrice(double newgoogPrice)
        {
            googPrice = newgoogPrice;
            NotifyObserver();
        }


    }
}
