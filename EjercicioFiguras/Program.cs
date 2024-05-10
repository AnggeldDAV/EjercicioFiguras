
using EjercicioFiguras.Modelo;

IFactoriaMedibles Factoria = new FactoriaFiguras();
IMedible figuraCuadrado = Factoria.Figura(EnumFiguras.Cuadrado, 2);
IMedible figuraCirculo = Factoria.Figura(EnumFiguras.Circulo, 2);
IMedible figuraCirculo2 = Factoria.Figura(EnumFiguras.Circulo, 3);



Console.WriteLine(figuraCuadrado);
Console.WriteLine(figuraCirculo);
Console.WriteLine(figuraCirculo2);

var tablero01 = new TableroFiguras();
tablero01.Add(figuraCuadrado);
tablero01.Add(figuraCirculo);
tablero01.Add(figuraCirculo2);


Console.WriteLine($"Perimetro total: {tablero01.DamePerimetroTotal()}");
Console.WriteLine($"Superficie total: {tablero01.DameSuperficieTotal()}");
Console.WriteLine($"Total de objetos: {tablero01.Count()}");

Console.WriteLine($"Media total Perimetro: {tablero01.DameMediaTotalPerimetro()}");
Console.WriteLine($"Media total Superficie {tablero01.DameMediaTotalSuperficie()}");

Console.WriteLine($"Superficie mas grande: {tablero01.DameSuperficieGrande()}");
Console.WriteLine($"Superficie mas pequena: {tablero01.DameSuperficiePequena()}");


