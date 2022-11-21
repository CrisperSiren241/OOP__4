using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    public class SemiJewel : Jewel
    {
        Jewel jewel;
        public SemiJewel(string name, string description, int value) : base(name, description, value)
        {
            this.jewel = new Jewel(name, description, value);
        }

        string SemiJewelStatus = "Часто продаваемый";
        public override string ToString()
        {
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value + "\n" + "Cтатус: " + SemiJewelStatus;
        }
    }
}
