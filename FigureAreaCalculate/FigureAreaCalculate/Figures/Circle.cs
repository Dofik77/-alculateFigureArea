using System;
namespace FigureSquareCalculate
{
    public class Circle : ICircle
    {
        Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if(value < 1)
                    throw new ArgumentException("Радиус круга должен быть больше нуля", nameof(Radius));

                radius = value;
            }
        }

        double radius { get; set ; }

        public double GetSquare() => Math.PI* Math.Pow(radius, 2);
    }
}

