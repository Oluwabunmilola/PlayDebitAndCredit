using System;

namespace DebitAndCredit
{
    class Program
    {
        static void Main(string[] args)
        {
      
           UserAccounts myuserAccounts = new UserAccounts();
           Console.WriteLine(myuserAccounts.credit(5000));
            Console.WriteLine(myuserAccounts.debit(2000));


        }
    }
}
