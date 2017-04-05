using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    public class NumberGenerator : INumberGenerator
    {
        public int Next()
        {
            return new Random().Next(1,101);
        }
    }
}
