using System;

namespace OOP__4
{
    class Program 
    { 
        static void Main()
        {
            Ruby ruby = new Ruby("Рубин", "Драгоценный камень, имеющий красный цвет", "Разновидность корунда", 4);
            Diamond diamond = new Diamond("Алмаз", "Драгоценный камень, самый твердый среди минералов","", 4);
            Emerald emerald = new Emerald("Изумруд", "Драгоценный камень, являющийся камнем 1 порядка","", 4);
            Flint flint = new Flint("Кремень","Камень, ипользуемый в ремесле","С помощью него изготавливается оружие");
            Thread thread = new Thread("Нить", "Длинный предмет","В данный момент товара нет в наличии");
            Printer printer = new Printer();

            /*object[] AllClasses = new object[] { ruby, diamond, emerald, flint, thread };
            foreach(object o in AllClasses)
            {
                printer.Print(o);
                Console.WriteLine();
            }*/

            Products products = new("Товар","Описание Товара");
            
            products.DoClone();
            ((IProducts)products).DoClone();

            NecklaceContainer container = new NecklaceContainer();
            
            NecklaceController necklace1 = new NecklaceController("Рубин", "Темный Изумруд", "Маленький Алмаз", 15, 3, 4);
            container.Add(necklace1);
            NecklaceController necklace2 = new NecklaceController("Светлый Рубин", "Обычный Изумруд", "Большой Алмаз", 13, 10, 5);
            container.Add(necklace2);
            NecklaceController necklace3 = new NecklaceController("Темно-крансый Рубин", "Маленький Изумруд", "Обычный Алмаз", 5, 13, 44);
            container.Add(necklace3);
            container.Print();
        }
    }

}