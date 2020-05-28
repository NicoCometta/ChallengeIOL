using CodingChallenge.Data.Classes.Idiomas.Interfaces;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Castellano : IIdioma
    {
        public string Area(bool plural) => plural ? "Areas" : "Area";

        public string Circulo(bool plural) => plural ? "Círculos" : "Círculo";

        public string Cuadrado(bool plural) => plural ? "Cuadrados" : "Cuadrado";

        public string Formas(bool plural) => plural ? "Formas" : "Forma";

        public string ListaVacia() => "Lista vacía de formas";

        public string Perimetro(bool plural) => plural ? "Perímetros" : "Perímetro";

        public string Rectangulo(bool plural) => plural ? "Rectángulos" : "Rectángulo";

        public string ReporteDeFormas() => "Reporte de Formas";

        public string Total(bool plural) => plural ? "Totales" : "Total";

        public string Triangulo(bool plural) => plural ? "Triángulos" : "Triángulo";
    }
}
