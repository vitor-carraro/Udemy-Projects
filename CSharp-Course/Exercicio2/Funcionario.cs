namespace Exercicio2
{
    internal class Funcionario
    {
        public string Nome = string.Empty;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
        }

        public override string ToString()
        {
            return string.Format("{0}, $ {1}", Nome, SalarioLiquido());
        }
    }
}
