﻿namespace ExerciciosInterfaces.Servicies
{
    internal interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int month);
    }
}
