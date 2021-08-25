// this file is built-in, this is where you run your application/program
using System;

namespace PracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // insert code to run your program here

            // Car is the data type (the class), NissanMaxima is the variable (or object), it is equal to a new Car() class
            // Car NissanMaxima = new Car();
            Car NissanMaxima = new Car("Nissan", "Maxima", "Navy", 2013);

            // set the values for your object using dot notation to access the attributes
/*          NissanMaxima.color = "Navy";
            NissanMaxima.make = "Nissan";
            NissanMaxima.model = "Maxima";
            NissanMaxima.year = 2013;
            NissanMaxima.isConvertible = false;
*/

            // set the values for an object using the constructor in its class model
            Car ToyotaRav4 = new Car("Toyota", "Rav4", "Silver", 2015);

            // Print to the console/terminal using Console.WriteLine or calling a method that has a print function
            Console.WriteLine(NissanMaxima.make + " " + NissanMaxima.model);
            NissanMaxima.DisplayCarInformation();
            ToyotaRav4.DisplayCarInformation();

            // change the paint color of the car
            Console.WriteLine("Please enter a new color for the Toyota: ");
            ToyotaRav4.GiveCarPaintJob(Console.ReadLine());

            // Display toyota with new color
            ToyotaRav4.DisplayCarInformation();

            // Keeps Terminal Open
            Console.ReadLine();
        }
    }
}
