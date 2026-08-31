using System;

namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R;
        {   get => r;
            set => _r = ValidateR(value);
        }

        public Circle(string name, double r)
        {
            Name = name;
            R = r;
        }

        private double ValidateR(double value)
        {
            if (value <= 0)
                throw new ArgumentException("El radio (R) debe ser mayor a cero.");
            return value;
        }

        public override double GetArea() => Math.PI * Math.Pow(R, 2);

        public override double GetPerimeter() => 2 * Math.PI * R;         
        
    }
}
