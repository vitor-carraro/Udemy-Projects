namespace ExerciciosInterfaces.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; private set; }
        public double Amount { get; private set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1:F2}", DueDate.ToShortDateString(), Amount);
        }
    }
}
