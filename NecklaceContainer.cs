using System;
using System.Collections;
using System.ComponentModel;


namespace OOP__4
{
    public class NecklaceContainer
    {
        object[] List = {};

        public NecklaceContainer() { }

        public void Add(object elem)
        {
            if (List == null)
            {
                object[] List = new object[1];
                List[List.Length] = elem;
            }
            else
            {
                for(int i=List.Length; i < List.Length; i++)
                {
                    List[List.Length+1] = elem;
                }
            }
        }

        public void Remove(object elem, int position)
        {
            for(int i=position; i < List.Length; i++)
            {
                List[i] = List[i + 1];
            }
        }

        public void Print()
        {
            foreach(object elem in List)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
