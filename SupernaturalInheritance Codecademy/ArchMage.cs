﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupernaturalInheritance_Codecademy
{
    class ArchMage : Mage
    {
        public ArchMage(string Title) : base(Title) { }

        public override Storm CastRainStorm()
        {
            return new Storm("Rain", true, Title);
        }

        public Storm CastLightningStorm()
        {
            return new Storm("Lightning", true, Title);
        }
    }
}
