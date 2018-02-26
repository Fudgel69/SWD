using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockObserver
{

    public class Stock : ISubject
    {
        //List of Observers is created
        private List<IObserver> observers;

        //Stock Constructor
        public Stock(string name, double value)
        {
            Name = name;
            Value = value;
            observers = new List<IObserver>();
        }

        #region get/set methods

        //get and set Name of Stock
        public string Name { get; private set; }

        //get and set Value of Stock
        public double Value { get; set; }

        //
        public int count { get; set; }


        public void SetValueNotify(double _value)
        {
            Value = _value;
            NotifyObserver();
        }

        #endregion


        #region StockObserver impl
        public void RegisterObserver(IObserver o) //Add observer
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o) //Remove observer
        {
            observers.Remove(o);
        }

        public void NotifyObserver() //Notify Observer
        {
            foreach (var o in observers)
            {
                o.update(Name, Value);
            }
        }
        #endregion

    }
}
