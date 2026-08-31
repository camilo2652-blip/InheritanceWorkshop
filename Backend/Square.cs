using System;

namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        protected double _a;

        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        public Square(string name, double a)
        {
            Name = name;
            A = a;
        }

        protected virtual double ValidateA(double value)
        {
            if (value <= 0)
                throw new ArgumentException("El lado (A) debe ser mayor que cero.");
            return value;
        }

        public override double GetArea() => Math.Pow(A, 2);

        public override double GetPerimeter() => 4 * A;
    }
}
