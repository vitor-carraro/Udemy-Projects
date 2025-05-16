namespace ExercicioFixacao
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ContaBancaria(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Deposito(depositoInicial); // Pois o saldo está implementado na lógica de deposito
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return string.Format("Conta {0}, Titular: {1}, Saldo: $ {2:F2}", Numero, Nome, Saldo);
        }
    }
}
