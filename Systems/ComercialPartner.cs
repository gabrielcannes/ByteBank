namespace C_OO2
{
    public class ComercialPartner : Autenticator
    {
        public string? Password {get;set;}
        public bool Autenticating(string password)
        {
            return Password == password;
        }
    }
}