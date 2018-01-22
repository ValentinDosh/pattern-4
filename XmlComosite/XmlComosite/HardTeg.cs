using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlComosite
{
    class HardTeg : Component
    {
        List<Component> tegs = new List<Component>();

        public HardTeg(string name) : base(name)
        {
        }

        public HardTeg(string name, string content) : base(name, content)
        {
        }

        public override void Add(Component component)
        {
            tegs.Add(component);
        }

        public override void Remove(Component component)
        {
            tegs.Remove(component);
        }


        // передают имя тега в котором будем искать и имя свойства
        public override string GetValueProperty(params string[] element)
        {
            // если в нашем елементе
            if (NameTeg == element[0])
            {
                foreach (var item in properties)
                {
                    if (element[1] == item.Key)
                        return item.Value;
                }
            }

            // если в коллекции
            foreach (var item in tegs)
            {
                if (item.NameTeg == element[0])
                {
                    foreach (var ite in item.properties)
                    {
                        if (element[1] == ite.Key)
                            return ite.Value;
                    }
                }
            }
            // если нет нигде
            return null;
        }
        
        public override void Print()
        {
            Console.Write("<{0}", NameTeg);
            foreach (var item in properties)
            {
                Console.Write(" {0}=\"{1}\"", item.Key, item.Value);
            }
            Console.WriteLine(">", NameTeg);


            Console.Write("{0}{1}", Content, String.IsNullOrEmpty(Content) ? "" : "\n");

            foreach (var item in tegs)
            {
                item.Print();
            }

            Console.WriteLine("</{0}>", NameTeg);
        }
    }
}
