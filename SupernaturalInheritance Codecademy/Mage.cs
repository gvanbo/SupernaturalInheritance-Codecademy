using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupernaturalInheritance_Codecademy
{
    class Mage : Pupil
    {
        public Mage(string Title ) : base(Title){ }

        public Storm CastRainStorm()
        {
            return new Storm("Rain", false, Title); 
        }


    }
}
