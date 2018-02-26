using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockObserver
{
    //Observer interface
    public interface IObserver
    {
        void update(string name, double value);
    }
}
