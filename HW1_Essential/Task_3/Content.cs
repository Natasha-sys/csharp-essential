using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Content
    {
        string content1;

        public string Content1
        {
            private get
            {
                if (content1 != null)
                    return content1;
                else
                    return "No content to display.";
            }
            set
            {
                content1 = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content1);
        }
    }
}
