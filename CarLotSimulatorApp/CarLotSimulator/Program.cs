using System;

namespace CarLotSimulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            CarLot carlot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            var firstCar = new Car();
            firstCar.Make = "Jeep";
            firstCar.Model = "Grand Cherokee";
            firstCar.Year = 2017;
            firstCar.EngineNoise = "Vroom";
            firstCar.HonkNoise = "Beep";
            firstCar.IsDriveable = true;

            carlot.CarList.Add(firstCar);

            var secondCar = new Car()
            {
                Make = "Dodge",
                Model = "Charger",
                Year = 2020,
                EngineNoise = "Vroom",
                HonkNoise = "Beep",
                IsDriveable = false
            };
            carlot.CarList.Add(secondCar);


            var thirdCar = new Car(2013, "Chevy", "Impala", "Vroom", "Beep", true);

            carlot.CarList.Add(thirdCar);


            //Set the properties for each of the cars
            //Call each of the methods for each car

            firstCar.MakeEngineNoise(firstCar.EngineNoise);
            secondCar.MakeEngineNoise(secondCar.EngineNoise);
            thirdCar.MakeEngineNoise(thirdCar.EngineNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//


            foreach (var car in carlot.CarList)
            {
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine();
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
                Console.WriteLine();
            }


            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
