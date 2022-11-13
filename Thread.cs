using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    public class Thread : Products
    {
        Products products;

        public Thread(string name, string description) : base(name, description)
        {
            this.name = name;
            this.description = description;
        }
        
        string ThreadDescription = "В данный момент товара нет в наличии";
        
        
        public override string ToString()
        {
            name = "Нить";
            description = "Тонкий, длинный предмет";
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Статус: "+ThreadDescription;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Thread thread) return true;
            return false;
        }
    }
}
