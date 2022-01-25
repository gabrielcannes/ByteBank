using finances;
using System.IO;

namespace C_OO2
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadAccounts();
        }

        private static void LoadAccounts()
        {
            using(FileReader fileReader = new FileReader("teste.txt"))
            {
                fileReader.ReadNextLine();
            } 
            // FileReader? fileReader = null;
            // try
            // {
            //     fileReader = new FileReader("contas1.txt");
            //     fileReader.ReadNextLine();
            //     fileReader.ReadNextLine();
            //     fileReader.ReadNextLine();
            // }
            // catch(IOException)
            // {
            //     Console.WriteLine ("Excessão do tipo IOException capturada e tratada.");
            // }
            // finally
            // {
            //     if (fileReader != null)
            //     {  
            //         fileReader.Close();
            //     }
            // }
        }
        private static void innerExceptionTest()
        {
            try
            {
                Client Gabriel = new Client("Gabriel","033.145.180-80","Desenvolvedor");
                CheckingAccount checkingAccount1 = new CheckingAccount(Gabriel,0453,001, 1000);
                CheckingAccount checkingAccount2 = new CheckingAccount(Gabriel,123,123, 5000);
                checkingAccount1.Transfer(checkingAccount2,2000);
            }
            catch(FinancesOperationsException)
            {
                // Console.WriteLine(e.InnerException.Message);
                // Console.WriteLine(e.InnerException.StackTrace);
            }
        }
        public static void BonusCalculation()
        {
            try 
            {
                BonusManager bonusManager = new BonusManager();
                Director director = new Director("Miguel","123",10000);
                AccountManager accountManager = new AccountManager("Julio","321",1000);
                Designer designer = new Designer("Laura","456",2000);
                Assistant assistant = new Assistant("Luan","654",10);
                Developer developer = new Developer("Gabriel","033145189800",2000);
                InternalSystem sys = new InternalSystem();

                sys.Login(director, "pass1");

                bonusManager.Register(director);
                bonusManager.Register(accountManager);
                bonusManager.Register(designer);
                bonusManager.Register(assistant);
                bonusManager.Register(developer);

                Console.WriteLine(bonusManager._totalBonuses);

                
            }
            catch (NotEnoghtMoneyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}