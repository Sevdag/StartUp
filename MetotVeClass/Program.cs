using System;

namespace MetotVeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "BMW";
            car.Model = "M4";
            car.ModalYear = 2019;
            car.Color = "Red";
            car.IsDamage = false;
            car.Km = 50000;
            car.IsAuto = false;

            Car car1 = new Car();
            car1.Brand = "Mercedes";
            car1.Model = "C180";
            car1.ModalYear = 2020;
            car1.Color = "Black";
            car1.IsDamage = true;
            car1.IsAuto = false;
            car1.Km = 3000;

            car1.banaRenkGoster();
            car.banaRenkGoster();

            //car1.EkranaYaz();
            //car1.EkranaParametreyiYaz(car1.Color);
            //car.EkranaParametreyiYaz("Kırmızı");

            //Console.WriteLine(car1.Model);

        }
    }
}
