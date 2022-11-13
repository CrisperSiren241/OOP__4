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
        public SemiJewel(string name, string description) : base(name, description)
        {
            
        }
        public override string ToString()
        {
            name = "Полудрагоценный камень";
            description = "Камень, уступающий по ценности драгоценного камня";
            value = 0;
            status = "Часто продаваемый";
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value + "\n" + "Cтатус: " + status;
        }
    }
}
