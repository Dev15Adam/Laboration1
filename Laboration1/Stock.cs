using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class Stock
    {
        StockItem[] items;
        public StockItem this[int index]
        {
            get
            {
                if (index >= 0 && index < items.Length)
                    return items[index];
                throw new Exception("Index out of bounds");
            }
            private set
            {
                if (index >= 0 && index < items.Length && value != null)
                    items[index] = value;
                else
                    throw new Exception("Something went wrong");
            }
        }

        public Stock()
        {
            items = new StockItem[0];
        }

        public void AddItem(StockItem item)
        {
            StockItem[] newItemsArray = new StockItem[items.Length + 1];
            items.CopyTo(newItemsArray,0);
            newItemsArray[items.Length] = item;
            items = newItemsArray;
        }
        public StockItem GetItem(int itemId)
        {
            foreach (StockItem item in items)
            {
                if (item.Id == itemId)
                    return item;
            }
            throw new Exception("Could not find item with given Id");
        }
    }
}
