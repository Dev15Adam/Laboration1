using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class Juice : EcoStockItem
    {
        string type;

        public string Type
        {
            get { return type; }
            set
            {
                if (value.ToLower() == "apple" || value.ToLower() == "orange")
                    type = value;
                else
                    throw new Exception("Type must be either 'Apple' or 'Orange'");
            }
        }

        public Juice (int id, string name, string mark, string type) : base(id, name, mark)
        {
            Type = type;
        }

        public override string ToString() => $"{base.ToString()} Type:{Type}";
    }
}
