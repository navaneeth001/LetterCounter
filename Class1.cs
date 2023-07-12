using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthHelperLibrary
{
    public class LengthHelper
    {
        public int FindLength(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            return input.Length;
        }
    }
}

