using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    public class Jewel : Rock
    {
        Rock rock;
        public Jewel(string name, string description) : base(name, description)
        {
            
        }

        public string? feature;
        public override string ToString()
        {
            name = "Драгоценный камень";
            description = "Это очень дорогой камень";
            value = 0;
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value + "\n" + "Cтатус: " + status;
        }
    }
}
