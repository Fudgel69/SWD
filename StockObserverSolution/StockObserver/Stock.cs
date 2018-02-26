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

        //get and set number of Stock
        public int count { get; set; }

        //Set Value and call Observer Notify
        public void SetValueNotify(double _value)
        {
            Value = _value;
            NotifyObserver();
        }

        #endregion


        #region StockObserver impl

        //Add Observer to List of Observers
        public void RegisterObserver(IObserver o) 
        {
            observers.Add(o);
        }

        //Remove an Observer
        public void RemoveObserver(IObserver o) 
        {
            observers.Remove(o);
        }

        //Notify Observer and call update
        public void NotifyObserver() 
        {
            foreach (var o in observers)
            {
                o.update(Name, Value);
            }
        }
        #endregion

    }
}
