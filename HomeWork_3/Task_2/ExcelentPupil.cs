using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class ExcelentPupil : Pupil
    {
        public override void Study() { Console.WriteLine($"Pupil studies excelent");}
        public override void Read() { Console.WriteLine($"Pupil reads excelent"); }
        public override void Write() { Console.WriteLine($"Pupil writes excelent"); }
        public override void Relax() { Console.WriteLine($"Pupil can relax excelent"); }


    }
}
