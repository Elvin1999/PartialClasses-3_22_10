namespace ConsoleApp3
{
  
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(100,"IBAZA1234567854");
            Console.WriteLine(account.AccountSwift);
            account.Start();


            account.ShowAccountCall();
            account.UpdateAccountCall();

        }
    }
}