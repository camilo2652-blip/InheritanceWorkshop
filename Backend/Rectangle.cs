using System;

namespace GeometricFigures.Backend
{
    public class Rectangle : Square
    {
        protected double _b;

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

        protected virtual double Validate(double value)
        {
            if (value <= 0)
                throw new ArgumentException("El lado (B) debe ser mayor a cero.");
            return value;
        }

        public override double GetArea() => A * B;

        public override double GetPerimeter() => 2 * (A + B);
        

    }
}
