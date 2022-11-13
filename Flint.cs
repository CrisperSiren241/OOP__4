using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    public class Flint : Rock
    {
        public Flint(string name, string description) : base(name, description)
        {
            name = "Кремень";
            description = "Полудрагоценный камень, используемый в различным отраслях";
        }
        string Object = "Используется для создания оружия";
        public override string ToString()
        {
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Назначение: " + Object;
        }
    }
}
