using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Library
{
    public static class UserOutput
    {
        public static void FindCarsMessage(int count)
        {
            Console.WriteLine($"Available car count is: {count}");
        }
        
        public static void CongratsMessage(string model)
        {
            Console.WriteLine(
                $"Congrats with purchasing car: {model}.");
                //$"Would you like to receive the receipt?(Yes/No)");
        }

        public static void ReceiptMessage(string receiptData)
        {
            Console.WriteLine(receiptData);
        }

        public static void NoCarWithIdMessage(int carId) //name carId different than nikita
        {
            Console.WriteLine($"There is no cars with id: {carId}");
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Please choose car operation:");
            Console.WriteLine("1. Add car to the shop");
            Console.WriteLine("2. Find car by is available");
            Console.WriteLine("3. Find car by year");
            Console.WriteLine("4. Show list of all presented cars");
            Console.WriteLine("5. Buy a car");
        }

        public static void ChooseModelMessage()
        {
            Console.WriteLine("Please add car model:");
        }
        public static void ChooseColorMessage()
        {
            Console.WriteLine("Please add car color:");
        }
        public static void ChooseYearMessage()
        {
            Console.WriteLine("Please add car year:");
        }
        public static void ChooseIdMessage()
        {
            Console.WriteLine("Please add car ID:");
        }
        public static void CreateMoreCarsMessage()
        {
            Console.WriteLine("Do you want to create more cars?(Yes/No)");
        }
        public static void ProvideYearMessage()
        {
            Console.WriteLine("Please provide year:");
        }

        public static void FoundCarMessage(int id, string model)
        {
            Console.WriteLine($"Found car:{model}, ID no: {id}");
        }

        public static void ShowListOfCarsMessage(int id, string model, int i)
        {
            Console.WriteLine($"{i}. Car with {id} and model: {model}");
        }

        public static void BuyCarWithIdMessage()
        {
            Console.WriteLine($"Please choose the car ID from the list to buy it");
        }

        public static void PressEnterToGetReceipt()
        {
            Console.WriteLine("Press enter to get receipt");
        }
    }
}
