using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class ClassRoom
    {
        public Pupil pupil1;
        public Pupil pupil2;
        public Pupil pupil3;
        public Pupil pupil4;
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3 = null, Pupil pupil4 = null)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
            this.pupil4 = pupil4;

        }
        public void Show()
        {

            pupil1.Show();
            
            pupil2.Show();

            if (pupil3 != null)
            {
                pupil3.Show();
            }
            if (pupil4 != null)
            {
                pupil4.Show();
            }
        }

    }
}
