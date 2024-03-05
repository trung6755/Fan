using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan fan = new Fan("Mitsubishi", "Black");
            fan.turnON();
            fan.Info();
            
        }
    }
}
