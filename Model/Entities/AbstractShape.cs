using ExInterfaceAbstract.Model.Enums;

namespace ExInterfaceAbstract.Model.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
