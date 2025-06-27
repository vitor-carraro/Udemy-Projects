namespace ExercicioExcecoes.Entities.Exceptions
{
    internal class WithdrawLimitExecption : ApplicationException
    {
        public WithdrawLimitExecption()
        {
        }

        public WithdrawLimitExecption(string? message) : base(message)
        {
        }

        public WithdrawLimitExecption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

    }
}
