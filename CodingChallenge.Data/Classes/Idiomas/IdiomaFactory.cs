using CodingChallenge.Data.Classes.Idiomas.Interfaces;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class IdiomaFactory
    {
        public IIdioma Crear(Enum.Idiomas idioma)
        {
            switch (idioma)
            {
                case Enum.Idiomas.Castellano:
                    return new Castellano();
                case Enum.Idiomas.Ingles:
                    return new Ingles();
                default:
                    //Lenguage by default
                    return new Ingles();
            }
        }
    }
}
