using System;

namespace OOP__4
{
    sealed class Emerald : Jewel
    {
        Jewel jewel;
        public Emerald(string name, string description) : base(name, description)
        { 
        
        }
        public override string ToString()
        {
            feature = "Самоцветный камень 1 порядка";
            name = "Изумруд";
            value = 5;
            description = "Драгоценный камень, имеющий зеленый оттенок";
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value + "\n"
                + "Особенность: " + feature + "\n" + "Cтатус: " + status;
        }
    }
}
