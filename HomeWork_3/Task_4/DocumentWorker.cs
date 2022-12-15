using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class DocumentWorker
    {

        public virtual void OpenDocument()
        {
            Console.WriteLine("Document is opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Document editing in Pro version");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Document saving in Pro version");
        }
    }
}
