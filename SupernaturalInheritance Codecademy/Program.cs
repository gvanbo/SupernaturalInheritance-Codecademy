using System;

namespace SupernaturalInheritance_Codecademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm s1 = new Storm("Sand Storm", true, "Gandalf the Grey");

            Console.WriteLine(s1.Announce());
        }
    }
}
