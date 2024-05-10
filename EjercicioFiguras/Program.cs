
using EjercicioFiguras.Modelo;

IFactoriaMedibles Factoria = new FactoriaFiguras();
IMedible figuraCuadrado = Factoria.Figura(EnumFiguras.Cuadrado, 2);
IMedible figuraCirculo = Factoria.Figura(EnumFiguras.Circulo, 2);


Console.WriteLine(figuraCirculo);
Console.WriteLine(figuraCuadrado);
