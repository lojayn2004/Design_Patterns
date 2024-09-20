using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatter
{
    internal class ItalicDecorator: TextDecorator
    {
       public  ItalicDecorator(TextFormat format): base(format) { }

        public override string GetFormattedString()
        {
           
            return $"{format.GetFormattedString()};4m{base.format.text}\x1b[0m";
        }
    }
}
