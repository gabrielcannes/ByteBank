using finances;

namespace C_OO2
{
    public class CheckingAccount
    {
        public int Agency{get; set;}
        public int Number{ get; set;}
        public Client Owner{get; set;}
        private double _balance;
        public int NotPermitedWithdrawalConter {get; private set;}
        public int NotPermitedTransferencesCounter{get;private set;}
        public static int TotalCreatedCounts{get; set;}
        private Validations val = new Validations();

        public CheckingAccount(Client owner,int agency, int number, double balance)
        {
           TotalCreatedCounts++;
           verifyNegativeBalance(balance);
           Agency = agency;
           Number = number;
           Owner = owner;
        }

        private void verifyNegativeBalance(double balance)
        { 
            if (balance < 0)
            {
                Console.WriteLine("Valor inicial da conta invalido, a conta ira iniciar com 0");  
                _balance = 0;  
            }
            else _balance = balance;
        }

        public double Balance
        {
            get{return _balance;}
            set
            {
                if(value<0) return;
                _balance = value;
            }
        }
        
        public void Deposit(double value)
        {
            _balance = _balance + value;
        }
        public void Withdrawal(double value)
        {
            if (value  <= 0 ) throw new ArgumentException("Withdrawal value must be higher then zero",nameof(value));
            if (value > _balance)
            {
                NotPermitedWithdrawalConter++;
                throw new NotEnoghtMoneyException(_balance,value);
            } 
            else this._balance = _balance - value;
        }

        public void Statement()
        {
            Console.WriteLine("Seu saldo eh de:" + _balance.ToString());
        }
        public void Transfer(CheckingAccount recievingAcc, double value)
        {
            if (value  <= 0 ) throw new ArgumentException("Transfer value must be higher then zero",nameof(value));
            if (!val.PossibleWithdrawal(this,value))
            {
                Console.WriteLine("Saldo insuficiente para a transferencia.");
                return;
            } 

            try
            {
                this.Withdrawal(value);
            }
            catch(NotEnoghtMoneyException e)
            {
                NotPermitedTransferencesCounter++;
                throw new FinancesOperationsException("Operação não realizada.",e);
            }
            recievingAcc.Deposit(value);
            Console.WriteLine("Transferencia realizada com sucesso.");
        }
    }
}