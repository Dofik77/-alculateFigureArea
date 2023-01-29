using System;
namespace FigureSquareCalculate
{
    public interface ITriangle : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
    }
}

