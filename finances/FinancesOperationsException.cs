namespace finances
{
    public class FinancesOperationsException:Exception
    {
        public FinancesOperationsException(){}

        public FinancesOperationsException(string message)
        : base(message){}

        public FinancesOperationsException(string message, Exception innerExeption)
        :base (message,innerExeption){}
    }
}