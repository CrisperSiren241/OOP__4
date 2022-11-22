using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    internal class NecklaceController
    {
        string rubyName;
        string diamondName;
        string emeraldName;
        int rubyValue;
        int diamondValue;
        int emeraldValue;
        double rubyPrice = 14.4;
        double diamondPrice = 21.2;
        double emeraldPrice = 45.6;

        public NecklaceController(string rubyName, string diamondName, string emeraldName, int rubyValue, int diamondValue, int emeraldValue)
        {
            this.rubyName = rubyName;
            this.diamondName = diamondName;
            this.emeraldName = emeraldName;
            this.rubyValue = rubyValue;
            this.diamondValue = diamondValue;
            this.emeraldValue = emeraldValue;
        }

        public void Task()
        {
            Console.Write("Name of Ruby: ");
            rubyName = Console.ReadLine();
            Console.Write("Name of Diamond: ");
            diamondName = Console.ReadLine();
            Console.Write("Name of Emerald: ");
            emeraldName = Console.ReadLine();
            Console.Write("Amount of Ruby: ");
            rubyValue = int.Parse(Console.ReadLine());
            Console.Write("Amount of Diamond: ");
            diamondValue = int.Parse(Console.ReadLine());
            Console.Write("Amount of Emerald: ");
            emeraldValue = int.Parse(Console.ReadLine());
        }

        public double KaratAmount()
        {
            double sum=0;
            sum = rubyValue * rubyPrice + diamondValue * diamondValue + emeraldValue * emeraldValue;
            return sum;
        }

        public void SortJewel()
        {
            double[] PriceArray = { rubyPrice, diamondPrice, emeraldPrice };
            Array.Sort(PriceArray);
            foreach(int n in PriceArray)
            {
                Console.WriteLine(n);
            }
        }

        public override string ToString()
        {
            return "Состав: " + rubyName+", " + diamondName + ", " + emeraldName + ", " + "\n" + "Цена: "+KaratAmount();
        }
    }
}
