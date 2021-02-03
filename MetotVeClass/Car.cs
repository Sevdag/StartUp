using System;
using System.Collections.Generic;
using System.Text;

namespace MetotVeClass
{
    class Car:Metot
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool IsAuto { get; set; }
        public int Km { get; set; }
        public int ModalYear { get; set; }
        public bool IsDamage { get; set; }


        //public void EkranaYaz()
        //{
        //    Console.WriteLine("Ekrana Yazdır");
        //}

        //public void EkranaParametreyiYaz(string renk)
        //{
        //    Console.WriteLine("Arabanın rengi : " + renk);
        //}

        public void banaRenkGoster()
        {
            Console.WriteLine("Araba sınıfının renkleri");    
        }

        public void yas()
        {
            throw new NotImplementedException();
        }
    }


}
