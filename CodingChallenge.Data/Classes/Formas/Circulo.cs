using CodingChallenge.Data.Classes.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Circulo : IFormaGeometrica
    {
        private readonly decimal _radio;

        public Circulo(decimal radio)
        {
            _radio = radio;
        }
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_radio * _radio);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * 2 *_radio;
        }
    }
}
