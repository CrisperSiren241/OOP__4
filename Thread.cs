using System;

namespace OOP__4
{
    public class Thread : Products
    {
        Products products;

        string ThreadDescription;
        public Thread(string name, string description, string ThreadDescription) : base(name, description)
        {
            this.products = new Products(name, description);
            this.ThreadDescription = ThreadDescription;
        }

        public override string ToString()
        {
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
