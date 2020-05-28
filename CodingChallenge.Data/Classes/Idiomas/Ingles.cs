using CodingChallenge.Data.Classes.Idiomas.Interfaces;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Ingles : IIdioma
    {
        public string Area(bool plural) => plural ? "Areas" : "Area";

        public string Circulo(bool plural) => plural ? "Circles" : "Circle";

        public string Cuadrado(bool plural) => plural ? "Squares" : "Square";

        public string Formas(bool plural) => plural ? "Shapes" : "Shape";

        public string ListaVacia() => "Empty list of shapes";

        public string Perimetro(bool plural) => plural ? "Perimeters" : "Perimeter";

        public string Rectangulo(bool plural) => plural ? "Rectangles" : "Rectangle";

        public string ReporteDeFormas() => "Shapes report";

        public string Total(bool plural) => plural ? "Totals" : "Total";

        public string Triangulo(bool plural) => plural ? "Triangles" : "Triangle";
    }
}
