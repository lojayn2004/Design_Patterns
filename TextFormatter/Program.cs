
using TextFormatter;

class Program
{
    static void Main()
    {
        string text = "This is a decorated Text\n";

        Console.WriteLine("Text Before Decorating: ");
        Console.WriteLine(text);
       
        BoldText bold = new BoldText(text);


        TextDecorator h = new HighlightAndBoldTextDecorator(bold);
        Console.WriteLine("Text After Decorating: ");
        Console.WriteLine(h.GetFormattedString());

        
        TextDecorator h2 = new ItalicDecorator(bold);
        Console.WriteLine("Text After Adding Other Decorater: ");
        Console.WriteLine(h2.GetFormattedString());

    }
}