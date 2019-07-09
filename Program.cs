using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var ford = new Dictionary<string, string>(){
            {"Year", "1914"},
            {"Make", "Ford"},
            {"Model", "T"},
            {"Price", "300"}
            };

            var tesla = new Dictionary<string, string>(){
            {"Year", "2017"},
            {"Make", "Tesla"},
            {"Model", "X"},
            {"Price", "80000.45"}
            };

            var garage = new List<Dictionary<string, string>>();

            garage.Add(ford);
            garage.Add(tesla);

            Console.WriteLine(tesla["Year"]);


            car ford2 = new car();
            ford2.Year = 2017;
            ford2.Model = "Fiesta";
            ford2.Make = "Ford";
            ford2.Price = 32500.65;

            var tesla2 = new car()
            {
                Year = 2017,
                Model = "X",
                Make = "Tesla",
                Price = 80000.42,
            };

            var garage2 = new List<Dictionary<string, string>>();
            tesla2.Drive(100);
            ford2.Drive();

        }
    }


}
