using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    public class Diamond : Jewel
    {
        Jewel jewel;
        public Diamond(string name, string description, int value) : base(name, description, value)
        {
            this.jewel = new Jewel(name, description, value);   
        }

        public override string ToString()
        {
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value + "\n"
                 + "Особенность: " + feature + "\n" + "Cтатус: " + status;
        }
    }
}
