using System;
using System.Numerics;

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
            decimal balance = 0.00m;
            int play = 0;
            do
            {
                Console.WriteLine("Press 1 to see your Balance");
                Console.WriteLine("Press 2 to Withdraw money");
                Console.WriteLine("Press 3 to Deposit money");
                Console.WriteLine("Press 4 to exit");
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
                else if(action == 4)
                {
                    //Console.WriteLine($"Current Balance: ${balance}");
                    play = 1;
                }
                else
                {
                    Console.WriteLine("Enter a vaild option");
                }


            } while (play == 0);
        }




        ///////////////////////////////////////////////// VIEWBALANCE ///////////////////////////

        public static decimal ViewBalance(decimal balance)
        {
            return balance;

        }
        ////////////////////////////////////////////////////////////////////////////////////////



        ///////////////////////////////////////////////// TEST FOR VIEWBALANCE ///////////////////////
        public static decimal ViewBalanceTest(decimal balance)
        {
            return balance;

        }

        ////////////////////////////////////////////////////////////////////////////////////////



        
        //////////////////////////////////////// Withdraw ////////////////////////////////////////////////


        public static decimal Withdraw(decimal balance)

        {
            Console.Write("Select an amount: ");
            decimal withdrawal = Convert.ToInt32(Console.ReadLine());

            //while (withdrawal < 0)
            //{
            //    Console.Write("Select an amount: ");
            //    withdrawal = Convert.ToInt32(Console.ReadLine());
            //}


            if (balance > 0)
            {
                balance -= withdrawal;
            }
            else
            {
                balance = balance;
            }
            return balance;
        }

        ////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////// Test for Withdraw ////////////////////////////////////////////////

        public static decimal WithdrawTest(decimal balance, decimal withdrawal)
        {
            if (withdrawal > balance)
            {
                throw new Exception("Insufficient balance");
            }

            balance -= withdrawal;

            return balance;
        }

        ////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////// Test for Deposit ////////////////////////////////////////////////



        public static decimal Deposit(decimal balance)
        {

            Console.Write("Select an amount: ");
            decimal deposit = Convert.ToInt32(Console.ReadLine());
            //while (deposit < 0)
            //{
            //    Console.Write("Select an amount: ");
            //    deposit = Convert.ToInt32(Console.ReadLine());
            //}
            if (deposit > 0)
            {
                balance += deposit;

            }
            else
            {
                balance = balance;
            }
            return balance;


        }
        ////////////////////////////////////////////////////////////////////////////////////////
        

        ////////////////////////////////////////// Test for Deposit //////////////////////////////////////////////

        public static decimal DepositTest(decimal balance, decimal deposit)
        {
            if (deposit <= 0)
            {
                throw new Exception("Invalid Transaction");
            }

            balance += deposit;

            return balance;
        }

        ////////////////////////////////////////////////////////////////////////////////////////
    }
}

