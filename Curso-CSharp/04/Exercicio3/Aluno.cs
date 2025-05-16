namespace Exercicio3
{
    internal class Aluno
    {
        public string Nome = string.Empty;
        public double[] Notas = new double[3];

        public double NotaFinal()
        {
            return Notas[0] + Notas[1] + Notas[2];
        }

        public override string ToString()
        {
            string aprovacao;

            if (NotaFinal() < 60)
                aprovacao = string.Format("REPROVADO\nFALTARAM {0:F2} PONTOS", 60.0 - NotaFinal());
            else
                aprovacao = "APROVADO";

            return string.Format("NOTA FINAL = {0:F2}\n{1}", NotaFinal(), aprovacao);
        }
    }
}
