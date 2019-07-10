using System;

namespace ClassIntro


{
    public class car
    {
        private int _miles = 0;
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
            _miles += miles;
            Console.WriteLine($"{Make} is driving for the model {Model}");
            Console.WriteLine($"Your odometer is now at {_miles}");
        }
    }
}