using System;

namespace cs_bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isBanking = true;
            do
            {
                Console.WriteLine("WCCI Bank");
                Console.WriteLine("**************************************\n");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a new account");
                Console.WriteLine("2. Check balances of all accounts");
                Console.WriteLine("3. Withdraw from an account");
                Console.WriteLine("4. Deposit to an account");
                Console.WriteLine("5. Write a check");
                Console.WriteLine("6. Logout\n");
                string selectedAction = Console.ReadLine();

                if (selectedAction == "6")
                {
                    Console.WriteLine("Thanks for banking with us.  Good bye!");
                    isBanking = false;
                }
                else
                {
                    BankActions(selectedAction);
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (isBanking);
        }

        static void BankActions(string option)
        {
            switch (option)
            {
                case "1":
                    Console.WriteLine("Adding a new account coming soon...");
                    break;
                case "2":
                    Console.WriteLine("Check balances coming soon...");
                    break;
                case "3":
                    Console.WriteLine("Withdraw coming soon...");
                    break;
                case "4":
                    Console.WriteLine("Deposit coming soon...");
                    break;
                case "5":
                    Console.WriteLine("Write a check coming soon...");
                    break;
                default:
                    Console.WriteLine("Please select a valid menu option");
                    break;
            }
        }
    }
}
