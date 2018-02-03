using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlComosite
{
    abstract class Component
    {
        public string NameTeg;
        protected string Content;

        public Dictionary<string, string> properties = new Dictionary<string, string>();

        protected Component(string name)
        {
            NameTeg = name;
            Content = String.Empty;
        }

        protected Component(string name, string content)
        {
            NameTeg = name;
            Content = content;
        }

        // добавить свойство
        public void AddProperty(string name, string value)
        {
            properties.Add(name, value);
        }

        public virtual void Add(Component component) { }
        public virtual void Remove(Component component) { }

        // получаем имя свойства восвращаем значение
        public virtual string GetValueProperty(params string[] element)
        {
            foreach (var item in properties)
            {
                if (item.Key == element[0])
                    return item.Value;
            }
            return null;
        }
    

        public virtual void Print()
        {
            Console.Write("<{0}", NameTeg);
            foreach (var item in properties)
            {
                Console.Write(" {0}=\"{1}\"", item.Key, item.Value);
            }
            Console.WriteLine(">", NameTeg);


            Console.Write("{0}{1}", Content, String.IsNullOrEmpty(Content) ? "" : "\n");

            

            Console.WriteLine("</{0}>", NameTeg);
        }
    }
}
