using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pupil pupil1 = new GoodPupil();
            Pupil pupil2 = new BadPupil();
            Pupil pupil3 = new ExcelentPupil();
            Pupil pupil4 = new GoodPupil();


            ClassRoom classRoom2 = new ClassRoom(pupil1, pupil2);

            classRoom2.Show();

            Console.ReadKey();

        }
    }
}

