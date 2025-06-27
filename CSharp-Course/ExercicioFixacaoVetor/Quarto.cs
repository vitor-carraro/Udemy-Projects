namespace ExercicioFixacaoVetor
{
    internal class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Nome, Email);
        }
    }
}
