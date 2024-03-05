using System;
using System.Runtime.CompilerServices;

namespace Fan
{
    public class Fan
    {
        private string brand {  get; set; }
        private string color {  get; set; }
        public bool isOn = false;
        private int speed = 0;

        public Fan(string brand, string color)
        {
            isOn = false;
            this.brand = brand;
            this.color = color;
        }

        public void Info()
        {
            Console.WriteLine("This is a " + this.brand + " fan and its color is " + this.color);
            if (isOn)
            {
                Console.WriteLine("The fan speed is: " + speed);
            }
        }

        public void turnON()
        {
            isOn = true;
            Console.Write("Enter speed: ");
            speed = int.Parse(Console.ReadLine());
        }
    }
}
