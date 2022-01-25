using System;

namespace C_OO2
{
    public class Director : AutenticatorEmployee
    {
        public Director(string _name, string _doccument, double _salary) : base(_name,_doccument,_salary)
        {
            Salary = _salary;
            Doccument = _doccument;
            Name = _name;
        }

        public override double GetBonus()
        {
            return Salary * 0.5;
        }
        public override void Raise()
        {
            Salary *= 1.15;
        }
    }
}