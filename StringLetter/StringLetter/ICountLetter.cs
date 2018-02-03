using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLetter
{
    interface ICountLetter
    {
        string Value { get; set; }
        int CountLetter(char count);
    }
}
