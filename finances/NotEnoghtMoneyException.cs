using finances;

namespace C_OO2
{
    public class NotEnoghtMoneyException : FinancesOperationsException
    {
        public double Balance { get; }
        public double WithdrawalAmount { get; }

        public NotEnoghtMoneyException(){}

        public NotEnoghtMoneyException(double balance,double withdrawalAmount)
        : this("Not enought currency to withdrawal " + withdrawalAmount + " because the current balance of this account is: "+balance)
        {
            Balance = balance;
            WithdrawalAmount = withdrawalAmount;
        }

        public NotEnoghtMoneyException(string message)
            : base(message){}

         public NotEnoghtMoneyException(string message,Exception innerException)
            : base(message,innerException){}
    }
}