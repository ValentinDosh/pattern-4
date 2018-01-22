using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlComosite
{
    class Teg : Component
    {
        public Teg(string name) : base(name)
        {
        }

        public Teg(string name, string content) : base(name, content)
        {
        }
    }
}
