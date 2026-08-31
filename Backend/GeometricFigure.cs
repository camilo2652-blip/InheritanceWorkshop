using System;
using System.Globalization;


namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; } = String.Empty;

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            var culture = CultureInfo.InvariantCulture;
            string areaStr = GetArea().ToString("N5", culture);
            string perimeterStr = GetPerimeter().ToString("N5", culture);

            return string.Format(
                culture,
                "{0,15}=> Area.....:{1,15} Perimeter:{2,14}",
                Name,
                areaStr,
                perimeterStr);
        }
    }
}
