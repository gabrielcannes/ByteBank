namespace C_OO2
{
    public abstract class AutenticatorEmployee : Employee, Autenticator
    {
        public string? Password {get;set;}
        public AutenticatorEmployee(string _name, string _doccument, double _salary)
        : base(_name,_doccument,_salary)
        {
            
        }

        public bool Autenticating(string password)
        {
            return Password == password;
        }
    }
}