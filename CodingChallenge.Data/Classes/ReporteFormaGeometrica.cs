/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using CodingChallenge.Data.Classes.Formas;
using CodingChallenge.Data.Classes.Idiomas;
using CodingChallenge.Data.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class ReporteFormaGeometrica
    {
        private readonly IdiomaFactory _traductor;

        public ReporteFormaGeometrica()
        {
            _traductor = new IdiomaFactory();
        }

        //public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        public string Imprimir(List<IFormaGeometrica> formas, Idiomas.Enum.Idiomas idiomaElegido)
        {
            var idioma = _traductor.Crear(idiomaElegido);
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{idioma.ListaVacia()}!</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append($"<h1>{idioma.ReporteDeFormas()}!</h1>");

                var cuadrados = formas.OfType<Cuadrado>();
                var circulos = formas.OfType<Circulo>();
                var triangulos = formas.OfType<TrianguloEquilatero>();
                var rectangulos = formas.OfType<TrapecioRegular>();

                var numeroCuadrados = cuadrados.Count();
                var numeroCirculos = circulos.Count();
                var numeroTriangulos = triangulos.Count();
                var numeroRectangulos = rectangulos.Count();

                var areaCuadrados = cuadrados.Sum(c => c.CalcularArea());
                var areaCirculos = circulos.Sum(c => c.CalcularArea());
                var areaTriangulos = triangulos.Sum(c => c.CalcularArea());
                var areaRectangulos = rectangulos.Sum(c => c.CalcularArea());

                var perimetroCuadrados = cuadrados.Sum(c => c.CalcularPerimetro());
                var perimetroCirculos = circulos.Sum(c => c.CalcularPerimetro());
                var perimetroTriangulos = triangulos.Sum(c => c.CalcularPerimetro());
                var perimetroRectangulos = rectangulos.Sum(c => c.CalcularPerimetro());

                sb.Append(ObtenerLinea(idioma, idioma.Cuadrado(numeroCuadrados > 1), numeroCuadrados, areaCuadrados, perimetroCuadrados));
                sb.Append(ObtenerLinea(idioma, idioma.Circulo(numeroCirculos > 1), numeroCirculos, areaCirculos, perimetroCirculos));
                sb.Append(ObtenerLinea(idioma, idioma.Triangulo(numeroTriangulos > 1), numeroTriangulos, areaTriangulos, perimetroTriangulos));
                sb.Append(ObtenerLinea(idioma, idioma.Rectangulo(numeroRectangulos > 1), numeroRectangulos, areaRectangulos, perimetroRectangulos));

                // FOOTER
                sb.Append($"{idioma.Total(false)}:<br/>");

                var totalNumeros = numeroCuadrados + numeroCirculos + numeroTriangulos;
                sb.Append($"{totalNumeros} {idioma.Formas(totalNumeros>1)} ");

                var totalPerimetro = perimetroCuadrados + perimetroTriangulos + perimetroCirculos;
                sb.Append($"{idioma.Perimetro(totalPerimetro > 1)} {totalPerimetro.ToString("#.##")}");

                var totalArea = areaCuadrados + areaCirculos + areaTriangulos;
                sb.Append($"{idioma.Area(false)} {totalArea.ToString("#.##")}");
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(Idiomas.Interfaces.IIdioma idioma, string nombreForma, int cantidadFormas, decimal areaFormas, decimal perimetroFormas)
        {
            return $"{cantidadFormas} {nombreForma} | {idioma.Area(false)} {areaFormas:#.##} | {idioma.Perimetro(false)} {perimetroFormas:#.##} <br/>";
        }
    }
}
