using System;
using System.Collections.Generic;
using System.Text;

namespace mech_1
{
    class Computer
    {
        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isOn;
        public int tellmetheprice()
        {
            return price;
        }
        public float tellscreensize()
        {
            return screenSize;
        }
       public void turnon()
        {
            Console.WriteLine("turning on");
        }
        public void turnoff()
        {
            Console.WriteLine("shutting down");
        }
        public void addprocessor()
        {

        }

    }
}
