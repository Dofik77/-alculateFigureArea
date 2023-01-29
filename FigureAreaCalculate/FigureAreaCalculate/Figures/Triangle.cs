using System;
namespace FigureSquareCalculate
{
    public struct Triangle : ITriangle
    {
        Triangle(double SideA, double SideB, double SideC)
        {
            this.SideA = SideA;

            this.SideB = SideB;

            this.SideC = SideC;
        }

        private double perimeter;
        private double square;

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double GetSquare()
        {
            var sqrtA = Math.Sqrt(SideA);
            var sqrtB = Math.Sqrt(SideB);
            var sqrtC = Math.Sqrt(SideC);

            if ((SideA == SideB && SideA == SideC))
            {
                return ((Math.Sqrt(3) * (sqrtA)) / 4);
            }

            else if ((sqrtA + sqrtB == sqrtC) || (sqrtA + sqrtC == sqrtB) || (sqrtC + sqrtB == sqrtA))
            {
                var firstKatet = SideA > SideB && SideA > SideC ? SideB : SideA;
                var secondKatet = SideB > SideC && SideB > SideA ? SideC : SideB;

                Console.WriteLine("Это прямоугольный треугольник");

                return (firstKatet * secondKatet) / 2;
            }

            else if (!(SideA == SideB) && !(SideA == SideC) && !(SideB == SideC))
            {
                perimeter = (double)(SideA + SideB + SideC) / 2;

                square = (double)(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));

                return Math.Sqrt(square);
            }

            else if ((SideA == SideB) || (SideA == SideC) || (SideB == SideC))
            {
                //TODO 
                return 0;
            }

            else throw new Exception("Треугольника с такими сторонами не существует");
        }
    }
}

//table продукт- id,name (1,хлеб)
//тейбл кат - id, name
// смежная таебл = idpro,idкат

//SELECT FROM 3
//LEFT JOIN 