using System;
using CarShop.Library;
using System.Collections;
using System.Linq;

namespace CarShop.FrontEnd
{
    class Program
    {
        static readonly CarOperations carOperator = new CarOperations(); //Read-only??

        static void Main(string[] args)
        {
            UserOutput.ShowMenu();

            var exit = "continue";

            while (exit == "continue")
            {
                var option = Console.ReadLine();

                if (option is "exit") // OR if (option != null & option == exit)
                {
                    exit = option;
                }

                switch (option)
                {
                    case "1":
                        //Add car to the list/shop
                        AddingCars();
                        break;
                    case "2":
                        //Finding car that is available 
                        carOperator.FindAvailableCarsCount();
                        break;
                    case "3":
                        //Finding car by year
                        UserOutput.ProvideYearMessage();
                        var year = Convert.ToInt32(Console.ReadLine());
                        carOperator.GetCarByYear(year);
                        break;
                    case "4":
                        //Show list of all presented cars
                        carOperator.ShowListOfAllCars();
                        break;
                    case "5":
                        //Buying a car
                        carOperator.ShowListOfAllCars();
                        UserOutput.BuyCarWithIdMessage();
                        var id = Convert.ToInt32(Console.ReadLine());
                        carOperator.BuyCar(id);
                        
                        UserOutput.PressEnterToGetReceipt();
                        Console.ReadLine();

                        var carObject = carOperator.CarDictionary.FirstOrDefault(x => x.Key == id).Value;
                        if (carObject != null)
                        {
                            UserOutput.ReceiptMessage(carOperator.GetReciept(carObject));
                        }
                        
                        break;
                    
                    case "6":
                        //Geting receipt
                        break;
                }
            }
        }
        
        public static Car CreateCarObject()
        {
            var car = new Car();

            UserOutput.ChooseIdMessage();
            car.Id = Convert.ToInt32(Console.ReadLine());

            UserOutput.ChooseModelMessage();
            car.Model = Console.ReadLine();

            UserOutput.ChooseColorMessage();
            car.Color = Console.ReadLine();

            UserOutput.ChooseYearMessage();
            car.Year = Convert.ToInt32(Console.ReadLine());

            return car;
        }

        public static void AddingCars()
        {
            var continues = true;

            while (continues)
            {
                var car = CreateCarObject();
                carOperator.AddCarToTheList(car);

                UserOutput.CreateMoreCarsMessage();
                var yesNo = Console.ReadLine();
                if (yesNo == "Yes") continue;
                continues = false;
                UserOutput.ShowMenu();
            }
        }
    }
}
