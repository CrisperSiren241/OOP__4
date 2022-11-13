using System;

namespace OOP__4
{
    class Program 
    { 
        static void Main()
        {
            string name;
            string description;
            Products products = new Products("Товар", "Ниже приведены список товаров");
            Console.WriteLine();
            Jewel jewel = new Jewel("Драгоценный камень","Это очень дорогой камень");
            SemiJewel semiJewel = new SemiJewel("","");
            Ruby ruby = new Ruby("Рубин", "Драгоценный камень, имеющий красный цвет");
            Diamond diamond = new Diamond("Алмаз", "Драгоценный камень, самый твердый среди минералов");
            Emerald emerald = new Emerald("Изумруд", "Драгоценный камень, являющийся камнем 1 порядка");
            Flint flint = new Flint("Кремень","Камень, ипользуемый в ремесле");
            Thread thread = new Thread("Нить", "Длинный предмет");
            var obj = new Products ( "Товар", "Ниже приведены список товаров");
            object point = obj as AbstractMethods;
            
            if(point is AbstractMethods)
            { 
                point = obj as AbstractMethods;
            }
            
            Console.WriteLine(obj.stroke);
            Printer printer = new Printer();
            
            object[] AllClasses = new object[] { products, jewel, semiJewel, ruby, diamond, emerald, flint, thread };
            foreach(object o in AllClasses)
            {
                printer.Print(o);
                Console.WriteLine();
            }
            
            products.DoClone();
            ((IProducts)products).DoClone();
        }
    }

}