using System;

namespace Lab2
{
    public static class Program
    {
        static void Main(string[] args)
        {
            UserInterface();
        }

        public static void UserInterface()
        {
            Console.WriteLine("Welcome!");

            // Console.WriteLine("Current Balance: " + balance);
            decimal balance = 100.05m;
            int play = 0;
            do
            {
                Console.WriteLine("Press 1 to see your Balance");
                Console.WriteLine("Press 2 to Withdraw money");
                Console.WriteLine("Press 3 to Deposit money");
                int action = Convert.ToInt32(Console.ReadLine());


                if (action == 1)
                {
                    balance = ViewBalance(balance);
                    Console.WriteLine($"Current Balance: ${balance}");
                }
                else if (action == 2)
                {
                    balance = Withdraw(balance);
                    Console.WriteLine($"Current Balance: ${balance}");


                }
                else if (action == 3)
                {
                    balance = Deposit(balance);
                    Console.WriteLine($"Current Balance: ${balance}");

                }
                else
                {
                    Console.WriteLine("Enter a vaild option");
                }

               
            } while (play == 0);
        }





        public static decimal ViewBalance(decimal balance)
        {
            return balance;

        }

        ///////////////////////////////////////////////// TEST FOR VIEWBALANCE ///////////////////////////////////////
        public static decimal ViewBalanceTest(decimal balance)
        {
            return balance;

        }

        ///////////////////////////////////////////////// TEST FOR VIEWBALANCE ///////////////////////////////////////

        public static decimal Withdraw(decimal balance)

        {
            Console.Write("Select an amount: ");
            decimal withdrawal = Convert.ToInt32(Console.ReadLine());

            if (balance > 0)
            {
                balance -= withdrawal;
            }
            else
            {
                balance = 0;
            }
            return balance;
        }


        public static decimal WithdrawTest(decimal balance, decimal withdrawal)
        {
            Console.Write("Select an amount: ");


            if (balance > 0 && (withdrawal > 0 || withdrawal >= balance))
            {
                balance -= withdrawal;
            }
            else
            {
                balance = 0;
            }
            return balance;
        }


        public static decimal Deposit(decimal balance)
        {

            Console.Write("Select an amount: ");
            decimal deposit = Convert.ToInt32(Console.ReadLine());
            while (deposit < 0)
            {
                Console.Write("Select an amount: ");
                deposit = Convert.ToInt32(Console.ReadLine());
            }
            if (deposit > 0)
            {
                balance += deposit;

            }
            return balance;


        }




        public static decimal DepositTest(decimal balance, decimal deposit)
        {
            Console.Write("Select an amount: ");

            while (deposit < 0)
            {
                Console.Write("Select an amount: ");
                deposit = Convert.ToInt32(Console.ReadLine());
            }

            if (deposit > 0)
            {
                balance += deposit;

            }
            else
            {
                throw new Exception("invalid transaction");


            }
            return balance;
        }

    }
}

