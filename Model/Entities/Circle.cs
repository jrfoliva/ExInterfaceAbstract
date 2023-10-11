using ExInterfaceAbstract.Model.Enums;
using System.Globalization;

namespace ExInterfaceAbstract.Model.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color)
        {
            Radius = radius;
            Color = color;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return "Cirlce area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
