using ExercicioMembrosEstaticos;

Console.Write("Qual a cotação do dolar? ");
double cotacaoDolar = double.Parse(Console.ReadLine());
Console.Write("Quantos dólares você vai comprar? ");
double quantidade = double.Parse(Console.ReadLine());
Console.WriteLine("Valor a ser pago em reais = {0}", ConversorDeMoeda.DolarToReal(quantidade, cotacaoDolar));