using ExInterfaceAbstract.Model.Entities;
using ExInterfaceAbstract.Model.Enums;

namespace ExInterfaceAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interface tendo uma classe abstrata
            Console.WriteLine("Shapes");
            IShape circle = new Circle(55.55, Color.White);
            Console.WriteLine(circle);
            IShape rect = new Rectangle(50.0, 10.5, Color.Black);
            Console.WriteLine(rect);

        }
    }
}