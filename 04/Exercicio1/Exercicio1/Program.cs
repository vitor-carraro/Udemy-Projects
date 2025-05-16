using Exercicio1;


Retangulo retangulo = new();

Console.WriteLine("Entre a largura e altura do retângulo:");
retangulo.Largura = double.Parse(Console.ReadLine());
retangulo.Altura = double.Parse(Console.ReadLine());
Console.WriteLine("Area = {0}", retangulo.Area()); 
Console.WriteLine("Perímetro = {0}", retangulo.Perimetro());
Console.WriteLine("Diagonal = {0}", retangulo.Diagonal());