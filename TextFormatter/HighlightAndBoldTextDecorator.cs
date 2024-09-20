using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatter
{
    internal class HighlightAndBoldTextDecorator: TextDecorator
    {
        public HighlightAndBoldTextDecorator(TextFormat format) : base(format) { }

        public override string GetFormattedString()
        {
            
            return $"{format.GetFormattedString()};43m{base.format.text}\x1b[0m";
        }
    }
}
