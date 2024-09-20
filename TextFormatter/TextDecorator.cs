using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatter
{
    
        internal abstract class TextDecorator : TextFormat
        {
           protected TextFormat format;

            public TextDecorator(TextFormat format) 
            {
                this.format = format;
            }

            public override abstract string GetFormattedString();
        }
   

}
