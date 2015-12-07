using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class EcoStockItem : StockItem
    {
        string mark;

        public string Mark
        {
            get { return mark; }
            set
            {
                if (value == "Krav" || value == "EG")
                    mark = value;
                else
                    throw new Exception("Mark must be either 'Krav' or 'EG'");
            }
        }

        public EcoStockItem(int id, string name, string mark) : base(id, name)
        {
            Mark = mark;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Mark:{Mark}";
        }
    }
}
