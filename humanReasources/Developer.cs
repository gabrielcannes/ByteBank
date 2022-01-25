namespace C_OO2
{
    public class Developer : Employee
    {
         public Developer(string _name, string _doccument, double _salary) : base(_name,_doccument,_salary)
        {
            Salary = _salary;
            Doccument = _doccument;
            Name = _name;
        }
        public override double GetBonus()
        {
            return Salary * 0.15;
        }
        public override void Raise()
        {
            Salary *= 1.10;
        }
    }
}