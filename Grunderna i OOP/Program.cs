namespace Grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            Console.WriteLine($"Cirkels radie: {circle1.Radius}, Area: {circle1.Area:0.##}, Omkrets: {circle1.Circumference:0.##}\nVolym för sfär med samma radie: {circle1.VolumeIfItWereASphere:0.##}\n\n");
            Console.WriteLine($"Cirkels radie: {circle2.Radius}, Area: {circle2.Area:0.##}, Omkrets: {circle2.Circumference:0.##}\nVolym för sfär med samma radie: {circle2.VolumeIfItWereASphere:0.##}");
        }
    }
}