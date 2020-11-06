using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new CarLot();



            //Create a seperate class file called Car



            //Now that the Car class is created we can instanciate 3 new cars
            var reggiesCar = new Car();
            reggiesCar.Make = "Lexus";
            reggiesCar.Model = "IS300";
            reggiesCar.Year = 2019;
            reggiesCar.EngineNoise = "smooth";
            reggiesCar.HonkNoise = "beep";
            reggiesCar.IsDrivable = true;

            lot.Cars.Add(reggiesCar);



            var jonathansCar = new Car()
            {
                Year = 2020,
                Make = "BMW",
                Model = "Series 3",
                EngineNoise = "rough",
                HonkNoise = "honk",
                IsDrivable = false
            };

            lot.Cars.Add(jonathansCar);


            var sylviosCar = new Car(2018, "Lexus", "GS300", "smooth", "beep", true);
            lot.Cars.Add(sylviosCar);


            reggiesCar.MakeEngineNoise();
            jonathansCar.MakeEngineNoise();
            sylviosCar.MakeEngineNoise();

            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
