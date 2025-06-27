namespace ExercicioExcecoes.Entities.Exceptions
{
    internal class NoBalanceException : ApplicationException
    {
        public NoBalanceException()
        {
        }

        public NoBalanceException(string? message) : base(message)
        {
        }

        public NoBalanceException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
