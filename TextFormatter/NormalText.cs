using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatter
{
    internal class NormalText : TextFormat
    {

        public NormalText(string text)
        {
            base.text  = text;
        }
        public override string GetFormattedString()
        {
            return "";
        }
    }
}
