using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class ProDocumentWorker : DocumentWorker
    {

        public override void EditDocument()
        {
            Console.WriteLine("Document was edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in old format. It is possible to save Document in other formats in the Expert version");
        }
    }
}
