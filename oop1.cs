using System;

namespace mech_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer hp = new Computer();
            hp.model = "hp";
            hp.price = 3200;
            hp.numberOfProcessors = 3;
            hp.screenSize = 15;
            hp.isOn = true;
            Computer apple = new Computer();
            apple.model = "apple";
            apple.price = 3900;
            apple.numberOfProcessors = 2;
            apple.screenSize = 14;
            apple.isOn = true;
            Computer dell = new Computer();
            dell.model = "dell";
            dell.price = 2900;
            dell.numberOfProcessors = 2;
            dell.screenSize = 17;
            dell.isOn = false;
            hp.tellmetheprice();
            hp.tellscreensize();
            hp.turnoff();





            Console.ReadLine();
        }
    }
}
