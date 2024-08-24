using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProcessingSystem
{
    internal abstract class DocumentFactory
    {
        public void ProcessContent()
        {
            DocumentProcessor document = createDocumnetProcessor();
            document.ProcessDocument();
        }
        public abstract DocumentProcessor createDocumnetProcessor();


    }
}
