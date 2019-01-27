using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [DebuggerDisplay("COMPUTER MODEL = {_price * 0.267}")]
    class Computer
    {

        public string _model;
        public int _price;
        public int _numberOfProcessors;
        public float _screenSize;
        public bool _isOn = false;
        public int tellmetheprice()
        {
            return _price;
        }
        public float tellscreensize()
        {
            return _screenSize;
        }
        public void turnon()
        {
            Console.WriteLine("turning on");
            _isOn = true;
        }
        public void turnoff()
        {
            Console.WriteLine("shutting down");
            _isOn = false;
        }
        public void addprocessor()
        {
            _numberOfProcessors++;
        }
        public override string ToString()
        {
            return $"Computer model = {_model} price = {_price} number of processors = { _numberOfProcessors} screen size={_screenSize} is on = {_isOn}";
        }

    }
}
