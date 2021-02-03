using System;
using System.Collections.Generic;
using System.Text;

namespace MetotVeClass
{
    class Animal:Metot
    {
        public string Species { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public bool IsWild { get; set; }
        public bool IsSeaAnimal { get; set; }

        public void banaRenkGoster()
        {

            Console.WriteLine("Hayvan sınıfının rengini göster");        }

        public void yas()
        {
            throw new NotImplementedException();
        }
    }
}
