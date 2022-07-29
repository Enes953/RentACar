using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Car Manager = CarDataBase ***************");

            CarManager carManager = new CarManager(new EfCarDal());
            var Result = carManager.GetAll();

            foreach (var car in Result.Data)
            {
                Console.WriteLine(car.BrandId + " " + car.Description);
            }

        }
    }
}