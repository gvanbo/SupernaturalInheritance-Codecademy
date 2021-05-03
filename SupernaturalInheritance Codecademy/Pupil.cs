using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupernaturalInheritance_Codecademy
{
    class Pupil
    {
        public string Title { get; private set; }

        public Pupil(string title)
        {
            Title = title;
        }

        public Storm CastWindStorm()
        {
            Storm s2 = new("Wind", false, Title);
            return s2;
        }
    }
}
