using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProcessingSystem
{
    internal abstract class DocumentProcessor
    {

        public void ProcessDocument()
        {
            AddHeader();
            GenerateDocumnet();
        }

        public abstract void AddHeader();

        public abstract void GenerateDocumnet();

    }
}
