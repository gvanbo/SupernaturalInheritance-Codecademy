using System;

namespace SupernaturalInheritance_Codecademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm s1 = new Storm("Sand", true, "Gandalf the Grey");

            Console.WriteLine(s1.Announce());

            Pupil bilbo = new Pupil("Bilbo");
            Storm windStorm = bilbo.CastWindStorm();
            Console.WriteLine(windStorm.Announce());

            Mage m = new Mage("Dori");
            Storm rainStorm = m.CastRainStorm();
            Console.WriteLine(rainStorm.Announce());

            ArchMage sauroman = new ArchMage("Sauroman");
            Storm aRainStorm = sauroman.CastRainStorm();
            Storm sLightningStorm = sauroman.CastLightningStorm();

            Console.WriteLine(aRainStorm.Announce());
            Console.WriteLine(sLightningStorm.Announce());


        }
    }
}
