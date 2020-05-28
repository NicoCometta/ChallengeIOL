using CodingChallenge.Data.Classes.Interfaces;

namespace CodingChallenge.Data.Classes.Formas
{
    public class TrapecioRegular : IFormaGeometrica
    {
        private readonly decimal _ladoMenor;
        private readonly decimal _ladoMayor;

        public TrapecioRegular(decimal ladoMenor)
        {
            _ladoMenor = ladoMenor;
            _ladoMayor = ladoMenor * 2;
        }

        public decimal CalcularArea()
        {
            return _ladoMenor * _ladoMayor;
        }

        public decimal CalcularPerimetro()
        {
            return 2*(_ladoMenor + _ladoMayor);
        }
    }
}
