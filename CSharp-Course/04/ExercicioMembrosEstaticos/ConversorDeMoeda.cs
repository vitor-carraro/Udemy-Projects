namespace ExercicioMembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        public const double IOF = 6.0 / 100;

        public static double DolarToReal(double quantidade, double cotacao)
        {
            double total = cotacao * quantidade;
            return total + (total * IOF);
        }
    }
}
