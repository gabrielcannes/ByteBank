namespace C_OO2
{
    public class InternalSystem
    {
        public bool Login(Autenticator employee, string password)
        {
            bool autenticatedUser = employee.Autenticating(password);

            if (autenticatedUser)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            } 
            else
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            } 
        }
    }
}