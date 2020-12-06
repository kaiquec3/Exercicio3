using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_3
{
    class Quadrado
    {
        #region Atributos
        double diagonal;
        double area;
        #endregion

        #region Construtores
        public Quadrado()
        {
            this.diagonal = 0;
            this.area = 0;
        }

        public Quadrado(double diagonal)
        {
            this.diagonal = diagonal;
            this.area = 0;
        }
        #endregion

        #region Setters e Getters
        public void SetDiagonal(double diagonal)
        {
            this.diagonal = diagonal;
        }

        public double GetDiagonal()
        {
            return this.diagonal;
        }

        public double GetArea()
        {
            return this.area;
        }
        #endregion

        #region Métodos funcionais
        public double CalcularArea()
        {
            this.area = Math.Pow(this.diagonal, 2)/2;
            return this.area;
        }

        public double CalcularArea(double diagonal)
        {
            this.area = Math.Pow(diagonal, 2) / 2;
            return this.area;
        }
        #endregion
    }
}
