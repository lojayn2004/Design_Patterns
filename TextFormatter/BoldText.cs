using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatter
{
    internal class BoldText : TextFormat
    {
        public BoldText(string text)
        {
            base.text = text;

        }
        // getting use of ansi cause c# doesnot provide us by a way to turn text to bold
        public override string GetFormattedString()
        {
            return "1";
        }

        
    }
}
