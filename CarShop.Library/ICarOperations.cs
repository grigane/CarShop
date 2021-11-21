using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Library
{
    public interface ICarOperations
    {
        public void AddCarToTheList(Car car);
        //public Car FindCarByYear(int year);
        public Car[] FindCarByYear(int year); //switched to array, converting to array at some point
        public void FindAvailableCarsCount();
        public string GetReciept(Car car); // all info is in the car object thats why you put in here
        public void BuyCar(int id);
    }
}
