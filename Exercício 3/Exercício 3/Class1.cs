using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_3
{
    class Quadrado
    {
        double diagonal;
        double area;

        public void SetDiagonal(double p)
        {
            diagonal = p;
        }

        public double GetDiagonal()
        {
            return diagonal;
        }

        public double GetArea()
        {
            return area;
        }

        public double CalcularArea()
        {
            area = Math.Pow(diagonal, 2)/2;
            return area;
        }
    }
}
