using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Library
{
    public class CarOperations : ICarOperations
    {
        public Dictionary<int, Car> CarDictionary = new ();
        //public List<Car> ListOfCars = new(); //like arrays but more options with it, making an database
        //public Car[] CarArray = new Car[100]; //for now using the arrays

        public void AddCarToTheList(Car car)
        {
            //ListOfCars.Add(car);
            //var index = ListOfCars.Count(x => x != null);
            CarDictionary.Add(car.Id, car);
        }//yes

        public void FindAvailableCarsCount()
        {
            var count = CarDictionary.Count(x => x.Value != null && x.Value.IsAvailable)
            //var count = ListOfCars.Count(x => x is { IsAvailable: true }); //, please count all the objects which is available and true, ==true at the end?; if the object is null you cant get the value
            UserOutput.FindCarsMessage(count);                              // Modern option??: return CarArray.Count(x => x is {IsAvailable:true}); (x => x != null && x.IsAvailable)
        }//yes

        public Car[] FindCarByYear(int year)//yes
        {
            int index = 0;
            var carArray = new Car[100];
            var carList = CarDictionary.Where(x => x.Value != null && x.Value.Year == year);
            
            foreach (var car in carList)
            {
                carArray[index] = car.Value;
                index++;
            }
            return carArray;
            //return ListOfCars.Where(x => x != null && x.Year == year).ToArray();
            //where is a filtering the values, searching all the years, putting all in array
        }
       
        public void BuyCar(int id)//yes
        {
            var selectedCar = CarDictionary.FirstOrDefault(x => x.Value.Id == id) ;

            if (selectedCar.Value != null) // making sure that there actually are cars in the list/collection
            {
                selectedCar.Value.Sold = true;
                selectedCar.Value.IsAvailable = false;

                UserOutput.CongratsMessage(selectedCar.Value.Model);
            }
            else 
            {
                UserOutput.NoCarWithIdMessage(id);
            }
        }

        public string GetReciept(Car car) //yes Receipt class
        {
            var receipt = new Receipt()
            {
                Car = car,
                Date = DateTime.Now,
                ReceiptNumber = Guid.NewGuid().ToString()[..5], // to generate random string 
                SellerName = "Motors shop",
                SellerVatNumber = "LV4563782976"
            };
            
            return @$"
                    Receipt number: {receipt.ReceiptNumber}
                    Seller: {receipt.SellerName}
                    VAT no: {receipt.SellerVatNumber}
                    Model: {receipt.Car.Model}
                    Year: {receipt.Car.Year}
                    Color: {receipt.Car.Color}
                    Receipt date: {receipt.Date}
                    ";
        }

        public void GetCarByYear(int year)//yes
        {
            //Console.WriteLine("Please say which car year you are looking for?");
            
            var carArray = FindCarByYear(year);

            foreach (var car in carArray)
            {
                UserOutput.FoundCarMessage(car.Id, car.Model);
            }
        }

        public void ShowListOfAllCars() //this is how to see all the objects on the screen
        {
            var i = 0;

            foreach (var car in CarDictionary)
            {
                if (car.Value != null)
                {
                    UserOutput.ShowListOfCarsMessage(car.Value.Id, car.Value.Model, i);
                }
                i++;
            }
        }
        //public  void BuyCarWithId()
        //{
        //    UserOutput.BuyCarWithIdMessage();
        //    var inputIdNumber = Convert.ToInt32(Console.ReadLine());

        //    BuyCar(inputIdNumber); // marking the selected car with sold and available
        //                                       // if input number is equal to car Id from the cararray, then buying the car

        //}

        
    }
}
