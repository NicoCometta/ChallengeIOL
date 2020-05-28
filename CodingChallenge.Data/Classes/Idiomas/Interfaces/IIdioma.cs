namespace CodingChallenge.Data.Classes.Idiomas.Interfaces
{
    public interface IIdioma
    {
        string ListaVacia();
        string ReporteDeFormas();
        string Total(bool plural);
        string Formas(bool plural);
        string Perimetro(bool plural);
        string Area(bool plural);
        string Cuadrado(bool plural);
        string Circulo(bool plural);
        string Triangulo(bool plural);
        string Rectangulo(bool plural);
    }
}
