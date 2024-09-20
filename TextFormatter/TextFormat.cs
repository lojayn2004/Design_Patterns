using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatter
{
    internal abstract class TextFormat
    {
        public string text;

        public abstract string GetFormattedString();
    }
}
