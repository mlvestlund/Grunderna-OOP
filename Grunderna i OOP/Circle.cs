using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunderna_i_OOP
{
    internal class Circle
    {
        public double Radius {  get; }
        public double Area { get; }
        public double Circumference { get; }
        public double VolumeIfItWereASphere { get; }

        public Circle(double radius) //Constructor that gives radius a value
        {
            Radius = radius;
            Area = GetArea();
            Circumference = GetCircumference();
            VolumeIfItWereASphere = GetVolumeIfItWereASphere();
        }

        public double GetArea() //method that gives the area of given radius
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetCircumference()
        {
            return Math.PI * Radius * 2;
        }

        public double GetVolumeIfItWereASphere()
        {
            return (4 * Math.PI * Math.Pow(Radius, 3)) / 3;
        }

        public void PrintInfoAboutCircle(Circle circle)
        {
            Console.WriteLine($"Cirkels radie: {circle.Radius}, Area: {circle.Area:0.##}, Omkrets: {circle.Circumference:0.##}\nVolym för sfär med samma radie: {circle.VolumeIfItWereASphere:0.##}\n");
        }
    }
}
