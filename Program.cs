using System;

namespace template_csharp_virtual_pet
{
    class Program
    {
        static Pet myPet = new Pet();
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {

                // Print out menu

                // Get User Input
                int choice = Convert.ToInt32(Console.ReadLine());
                // Switch case for menu items
                switch (choice)
                {
                    case 1:
                        break;
                    case 3:
                        isRunning = false;
                        break;
                }
              
                
            }

            //Console.WriteLine("Press any key to continue.");
            //Console.ReadKey();
        }

        static void NamePet()
        {
            Console.WriteLine("What is the name of your pet?");
            string name = Console.ReadLine();

            Console.WriteLine("What is the species of your pet?");
            string species = Console.ReadLine();

            myPet.Name = name;
            myPet.Species = species;
        }
    }
}
