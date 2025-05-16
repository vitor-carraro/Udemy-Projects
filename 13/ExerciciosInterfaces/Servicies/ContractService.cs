using ExerciciosInterfaces.Entities;

namespace ExerciciosInterfaces.Servicies
{
    internal class ContractService
    {
        private readonly IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService paymentService)
        {
            _onlinePaymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double amount = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                double monthAmount = amount + _onlinePaymentService.Interest(amount, i);
                monthAmount += _onlinePaymentService.PaymentFee(monthAmount);

                contract.Installments.Add(new Installment(contract.Date.AddMonths(i), monthAmount));
            }
        }
    }
}
