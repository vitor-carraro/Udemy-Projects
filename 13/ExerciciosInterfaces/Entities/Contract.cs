﻿namespace ExerciciosInterfaces.Entities
{
    internal class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; private set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue, int numberOfInstallments)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>(numberOfInstallments);
        }

    }
}
