using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProcessingSystem
{
    internal class LetterFactory : DocumentFactory
    {
        public string Sender { get; set; }

        public string Reciever { get; set; }

        public string Subject { get; set; }

        public string LetterContent { get; set; }

        public LetterFactory(string sender, string reciever, string subject, string letterContent)
        {
            Sender = sender;
            Reciever = reciever;
            LetterContent = letterContent;
            Subject = subject;
        }

        public override DocumentProcessor createDocumnetProcessor()
        {
            return new LetterProcessor(Sender, Reciever, Subject, LetterContent);
        }
    }
}
