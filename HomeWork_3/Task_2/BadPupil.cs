using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public  class BadPupil:Pupil
    {
        public override void Study() { Console.WriteLine($"Pupil studies bad"); }
        public override void Read() { Console.WriteLine($"Pupil reads bad"); }
        public override void Write() { Console.WriteLine($"Pupil writes bad"); }
        public override void Relax() { Console.WriteLine($"Pupil can relax bad"); }

    }
}
