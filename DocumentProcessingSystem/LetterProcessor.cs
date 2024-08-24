using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProcessingSystem
{
    internal class LetterProcessor : DocumentProcessor
    {
        public string Sender { get; set; }

        public string Reciever { get; set; }

        public string Subject { get; set; }

        public string LetterContent { get; set; }

        public LetterProcessor(string sender, string reciever, string subject, string letterContent) { 
               Sender = sender;
               Reciever = reciever;
               LetterContent = letterContent;
               Subject = subject;
        }
        public override void AddHeader()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"From: {Sender}");
            Console.WriteLine($"To: {Reciever}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;

        }

        public override void GenerateDocumnet()
        {
            Console.Write("I hope this letter finds you well, ");
            Console.WriteLine(LetterContent);
            Console.WriteLine();
        }
    }
}
