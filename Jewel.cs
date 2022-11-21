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
        public int value;
        public Jewel(string name, string description, int value) : base(name, description)
        {
            this.rock = new Rock(name, description);
            this.value = value;
        }

        public string? feature;
        public override string ToString()
        {
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value + "\n" + "Cтатус: " + status;
        }
    }
}
