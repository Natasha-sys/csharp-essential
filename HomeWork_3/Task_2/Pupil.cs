using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Pupil
    {

        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }

        public void Show()
        {
            Console.WriteLine($"----");
            Console.WriteLine($"Results for: {this.GetType().Name}");
            this.Write();
            this.Read();
            this.Study();
            this.Relax();
        }

    }
}
