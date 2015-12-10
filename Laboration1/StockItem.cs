using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class StockItem
    {
        int id;
        string name;
        int stockCount;        

        public int Id
        {
            get { return id; }
            private set
            {
                if (value >= 0)
                    id = value;
                else
                    throw new Exception("Id must be a positive value");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                    name = value;
                else
                    throw new ArgumentNullException();
            }
        }
        public int StockCount
        {
            get { return stockCount; }
            set
            {
                if (value >= 0)
                    stockCount = value;
                else
                    throw new Exception("Stockcount must be a positive value");
            }
        }
        
        public StockItem(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"StockCount:{StockCount} Id:{Id} Name:{Name}";
        }
    }
}
