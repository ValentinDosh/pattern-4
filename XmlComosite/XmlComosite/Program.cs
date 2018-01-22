using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlComosite
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // построение XML документа
            Component XmlDocument = new HardTeg("Xml", "Главный тег");
            XmlDocument.AddProperty("fg", "fgfg");

            Component house = new HardTeg("house", "Дом состоит из многих элементов");
            house.AddProperty("qw", "qwqw");

            Component windoows = new Teg("Windows", "Окна могут быть деревянные или пластиковые");
            windoows.AddProperty("er", "erer");

            Component doors = new Teg("Doors");

            Component cities = new HardTeg("Cities", "Мой любимый город это мой город - Минск");
            cities.AddProperty("rt", "rtrt");
            cities.AddProperty("ty", "tyty");

            house.Add(windoows);
            house.Add(doors);

            XmlDocument.Add(house);
            XmlDocument.Add(cities);

            XmlDocument.Print();
   */




            // поиск свойства в простом элементе
            Component c = new Teg("house", "Мой любимый дом");
            c.AddProperty("name", "valentin");
            c.AddProperty("Age", "22");
            Console.WriteLine(c.GetValueProperty("Age"));
            Console.ReadLine();
        }
    }
}
