using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperCaseProxy
{
    class ProxyString : ICountLetter
    {
        public string Value { get; set; }
        String _string;

        public ProxyString(string str)
        {
            Value = str;
        }

        public int CountLetter(char count)
        {
            if (_string == null)
                _string = new String(Value);
            // теперь строка в верхнем регистре
            Value = Value.ToUpper();
            
            return _string.CountLetter(count); ;
        }
    }
}
