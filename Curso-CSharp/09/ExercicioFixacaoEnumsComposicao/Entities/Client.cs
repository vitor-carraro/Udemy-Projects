namespace ExercicioFixacaoEnumsComposicao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2}", Name, BirthDate.ToShortDateString(), Email);
        }
    }
}
