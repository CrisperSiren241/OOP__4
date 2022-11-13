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
        public Diamond(string name, string description) : base(name, description)
        {
            
        }

        public override string ToString()
        {
            feature = "Самый твердый минерал";
            name = "Алмаз";
            value = 3;
            description = "Драгоценный камень, являющийся одним из самых твердых минералов";
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value + "\n"
                 + "Особенность: " + feature + "\n" + "Cтатус: " + status;
        }
    }
}
