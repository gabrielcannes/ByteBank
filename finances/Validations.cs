using System;

namespace C_OO2
{
    public class Validations
    {
        public bool PossibleWithdrawal(CheckingAccount acc, double withdrawalValue)
        {
            if (acc.Balance < withdrawalValue) return false;
            else return true;
        }
    }
}