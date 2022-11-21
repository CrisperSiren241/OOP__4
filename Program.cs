using System;

namespace OOP__4
{
    class Program 
    { 
        static void Main()
        {
            Products products = new Products("Товар", "Ниже приведены список товаров");
            Console.WriteLine();
            Jewel jewel = new Jewel("Драгоценный камень","Это очень дорогой камень", 0);
            SemiJewel semiJewel = new SemiJewel("Полудрагоценный камень","Камень, уступающий, драгоценному камню",4);
            Ruby ruby = new Ruby("Рубин", "Драгоценный камень, имеющий красный цвет", 4);
            Diamond diamond = new Diamond("Алмаз", "Драгоценный камень, самый твердый среди минералов", 4);
            Emerald emerald = new Emerald("Изумруд", "Драгоценный камень, являющийся камнем 1 порядка", 4);
            Flint flint = new Flint("Кремень","Камень, ипользуемый в ремесле","С помощью него изготавливается оружие");
            Thread thread = new Thread("Нить", "Длинный предмет","В данный момент товара нет в наличии");
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