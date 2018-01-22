using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLetter
{
    class String : ICountLetter
    {
        public string Value { get; set; }

        public String()
        {
            Value = "";
        }

        public String(string str)
        {
            Value = str;
        }

        
        public int CountLetter(char count)
        {
            int sum = 0;
            for (int i = 0; i < Value.Length; i++)
            {
                if (Value[i] == count)
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
