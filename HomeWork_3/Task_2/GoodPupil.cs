using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class GoodPupil: Pupil
    {
        public override void Study() { Console.WriteLine($"Pupil studies good"); } 
        public override void Read() { Console.WriteLine($"Pupil reads good"); } 
        public override void Write() { Console.WriteLine($"Pupil writes good"); } 
        public override void Relax() { Console.WriteLine($"Pupil can relax good"); }

    }
}
