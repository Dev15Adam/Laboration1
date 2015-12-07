using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class Plate : StockItem
    {
        string type;

        public string Type
        {
            get
            { return type; }
            set
            {
                if (value == "Flat" || value == "Deep")
                    type = value;
                else
                    throw new Exception("Type must be either 'Flat' or 'Deep'");
            }
        }

        public Plate(int id, string name, string type) : base(id, name)
        {
            Type = type;
        }
        public override string ToString()
        {
            return base.ToString() + $" Type:{Type}";
        }
    }
}
