namespace Grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            circle1.PrintInfoAboutCircle(circle1);
            circle2.PrintInfoAboutCircle(circle2);
        }
    }
}