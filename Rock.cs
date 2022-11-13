using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    public class Rock : Products
    {
        Products _products;
        public Rock(string name, string description) : base(name, description)
        {
            name = "Камень";
            description = "Простой камень";
        }

        public string status = "Распространенный";
        public int value = 0;       
        public override string ToString()
            {
                name = "Камень";
                description = "Простой камень";
                return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value;
            }
        
    }
}
