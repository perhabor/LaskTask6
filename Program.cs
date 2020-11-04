using System;

namespace PolymorphismTest
{
    class Program
    {
        static void Main(string[] args)
        {
             var overnightPackage = new OverNightPackage("FCT", "BeninCity", 5000M);
            var twoDaysPackage = new TwoDaysPackage("Oyo", "Osun", 3000M);

    

            Console.WriteLine("\n Packages are processed polymorphically...\n");
            Packages[] packages = new Packages[2] { overnightPackage, twoDaysPackage };

            foreach (Packages package in packages)
            {
                Console.WriteLine($"{package}");
            }


        }
    }
}
