using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject
{
    class Car
    {
        // member variables for car class
        public string make;
        public string model;
        public string color;
        public int year;
        public bool isConvertible;

        // constructor
        public Car(string make, string model, string color, int year)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;

            isConvertible = false;
        }

        public void DisplayCarInformation()
        {
            Console.WriteLine("This car is a " + make + " " + model + ".");
            Console.WriteLine("It is a " + color + " a car from the year " + year + ".");
        }

        // member methods
        public void GiveCarPaintJob(string newColor)
        {
            color = newColor;
        }
    }
}
