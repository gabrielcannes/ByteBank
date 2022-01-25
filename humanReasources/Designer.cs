namespace C_OO2
{
    public class Designer : Employee
    {
        public Designer(string _name, string _doccument, double _salary) : base(_name,_doccument,_salary)
        {
            Salary = _salary;
            Doccument = _doccument;
            Name = _name;
        }
        public override double GetBonus()
        {
            return Salary * 0.17;
        }
        public override void Raise()
        {
            Salary *= 1.11;
        }
    }

    
}