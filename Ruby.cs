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
        public Ruby(string name, string description, int value) : base(name, description, value)
        {
            this.jewel = new Jewel(name, description, value);
        }
        public override string ToString()
        {
            feature = "Разновидность корунда";
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value + "\n" 
                + "Особенность: " + feature + "\n" + "Cтатус: " + status;
        }
    }
}
