using System.Globalization;
using ExInterfaceAbstract.Model.Enums;

namespace ExInterfaceAbstract.Model.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public Rectangle(double width, double heigth, Color color)
        {
            Width = width;
            Heigth = heigth;
            Color = color;
        }

        public override double Area()
        {
            return Width * Heigth;
        }

        public override string ToString()
        {
            return "Rectagle area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
