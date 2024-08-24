

using DocumentProcessingSystem;

class Program
{
    public static void Main()
    {
        var invoiceItems = new List<Tuple<string, decimal>>
        {
            new Tuple<string, decimal>("Item 1", 50.00m),
            new Tuple<string, decimal>("Item 2", 30.00m)
        };

        DocumentFactory invoice = new InvoiceFactory("ABC Company", "Ahmed", invoiceItems);

        invoice.ProcessContent();
      
        Console.WriteLine("\n\n");

        string letterContent = "I am writing to express my interest in enrolling \n" +
            "in the JavaScript course offered by you \n." +
            " As someone passionate about expanding my web development skills,\n" +
            " I believe that a strong understanding of JavaScript is essential for advancing my\n " +
            "capabilities and contributing more effectively to my projects.\n";
        DocumentFactory letter = new LetterFactory("Tarek M. ", "Mostafa Amar",
            "The new JavaScript Course", letterContent);
        letter.ProcessContent();
        

    }
}