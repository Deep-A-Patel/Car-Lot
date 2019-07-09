using System;

namespace ClassIntro


{
    internal class car
    {
        public int Year { get; set; }

        public string Model { get; set; }

        public string Make { get; set; }

        public double Price { get; set; }

        public void Drive()
        {

            if (Make == null)
            {
                Console.WriteLine($"Sorry Dawg, no make");
            }
            else
            {
                Console.WriteLine($"{Make}: I'm driving here!!!");
            }
        }

        public void Drive(int miles)
        {
            Console.WriteLine($"{Make} is driving for the model {Model}");
        }
    }
}