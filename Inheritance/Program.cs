using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal-DONE
            // give this class 4 members that all Animals have in common


            // Create a class Bird-DONE
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile-DONE
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird bird1 = new Bird()
            {
                HasFeathers = true,
                CanFly = true,
                CanSing = true,
                EatsCrackers = true,
                Name = "Polly"
            };

            

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Reptile snake = new Reptile()
            {
                Legs = 0,
                CanSwim = true,
                IsColdBlooded = true,
                Moves = "slithers",
                Name = "Mr. Slithers"
            };

            bird1.PrintDetails();
            snake.PrintDetails();

            Bird penguin = new Bird(2, true, true, true, false, false, false, false, "Squeaky");

            penguin.PrintDetails();
        }
    }
}
