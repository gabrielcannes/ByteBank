using System;

namespace C_OO2
{
    public class BonusManager
    {
        public double _totalBonuses {get;private set;}
        public void Register(Employee employee)
        {
            _totalBonuses += employee.GetBonus();
        }
    }
}