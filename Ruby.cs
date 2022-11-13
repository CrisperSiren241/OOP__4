using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    public class Ruby : Jewel
    {

        Jewel jewel;
        public Ruby(string name, string description) : base(name, description)
        {

        }
        public override string ToString()
        {
            feature = "Разновидность корунда";
            name = "Рубин";
            description = "Драгоценный камень, имеющий красный цвет";
            value = 4;
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value + "\n" 
                + "Особенность: " + feature + "\n" + "Cтатус: " + status;
        }
    }
}
