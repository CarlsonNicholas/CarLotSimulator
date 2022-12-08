using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE!
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car car_1 = new Car();
            Car car_2 = new Car();
            Car car_3 = new Car();

            // 2004 Ford Mustang - Car 1

            Console.WriteLine("Car 1!");

            car_1.Make = "Ford ";
            car_1.Model = "Mustang ";
            car_1.Year = 2004 ;
            car_1.EngineNoise = "Vroooom! ";
            car_1.HonkNoise = "honk honk ";
            car_1.IsDriveable = "Yes ";

            Console.WriteLine(car_1.Make);
            Console.WriteLine(car_1.Model);
            Console.WriteLine(car_1.Year);
            Console.WriteLine($"Is the car driveable: {car_1.IsDriveable}");
           
            car_1.MakeEngineNoise();
            car_1.MakeHonkNoise();

            Console.WriteLine();

            // 2002 Honda Civic - Car 2
           
            Console.WriteLine("Car 2!");

            car_2.Make = "Honda ";
            car_2.Model = "Civic ";
            car_2.Year = 2004 ;
            car_2.EngineNoise = "vro ";
            car_2.HonkNoise = "beep ";
            car_2.IsDriveable = "Kind of. ";

            Console.WriteLine(car_2.Make);
            Console.WriteLine(car_2.Model);
            Console.WriteLine(car_2.Year);
            Console.WriteLine($"Is the car driveable: {car_2.IsDriveable}");

            car_2.MakeEngineNoise();
            car_2.MakeHonkNoise();

            Console.WriteLine();

            // 2023 Chrysler 300 - Car 3

            Console.WriteLine("Car 3!");

            car_3.Make = "Chrysler ";
            car_3.Model = "300 ";
            car_3.Year = 2023 ;
            car_3.EngineNoise = "BROOM! BROOM! ";
            car_3.HonkNoise = "Ba-beep! ";
            car_3.IsDriveable = "Yes ";

            Console.WriteLine(car_3.Make);
            Console.WriteLine(car_3.Model);
            Console.WriteLine(car_3.Year);
            Console.WriteLine($"Is the car driveable: {car_3.IsDriveable}");

            car_3.MakeEngineNoise();
            car_3.MakeHonkNoise();

            Console.WriteLine();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
