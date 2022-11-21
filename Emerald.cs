using System;

namespace OOP__4
{
    sealed class Emerald : Jewel
    {
        Jewel jewel;
        public Emerald(string name, string description, int value) : base(name, description, value)
        {
            feature = "Самоцветный камень 1 порядка";
            name = "Изумруд";
            value = 5;
            description = "Драгоценный камень, имеющий зеленый оттенок";
        }
        public override string ToString()
        {
            
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value + "\n"
                + "Особенность: " + feature + "\n" + "Cтатус: " + status;
        }
    }
}
