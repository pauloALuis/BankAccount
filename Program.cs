using BankAccount.Entities;
using BankAccount.Entities.Type;
using BankAccount.Entities.Other;
using BankAccount.Entities.Account.Type;
using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(idPerson: "P-0001", firstName: "firtName1", lastName: "lastName1", birthDate: "20-05-1589", typeGener: Gender.Male);
            Accounts accounts = new Accounts(001, 100,person);
            person.FullName = "Maria joaao AAA";
            BusinessAccount businessAccount = new BusinessAccount(1002,0.0, person,500.0);


            Console.WriteLine( businessAccount);
            Console.WriteLine("\n\n");

            //upcasting
            Accounts accounts1 = businessAccount;
            Console.WriteLine("upcasting");
            Console.WriteLine("accounts1: " + accounts1);
            //

            Console.WriteLine("\n\n");
            person.IdPerson = "SAVInG01";
            person.FullName = "Gaspar marta";
            Accounts accounts2 = new SavingAccount(104, 250.5, person, 0.01) ;
            Console.WriteLine("accounts2: " + accounts2);

            //Dowcasting

            BusinessAccount account3 = (BusinessAccount)accounts1;
            Console.WriteLine("\n\nDowcasting");
            Console.WriteLine(account3);
            //accounts2.Loan(000) //not exist
            Console.WriteLine("\n\n Loan Limit operation\n\n");

            Console.WriteLine(account3.LoanLimit);
            //Dowcasting -- Unable to cast object of type 
            /* BusinessAccount account4 = (BusinessAccount)accounts2;
             Console.WriteLine("\n\nDowcasting");
            Console.WriteLine(account4);
            BusinessAccount account4 = (BusinessAccount)accounts2;*/
            BusinessAccount account5;
            if (accounts2 is BusinessAccount)
            {
                 account5 = (BusinessAccount)account3;
                account5.Loan(500);
                Console.WriteLine("Loan!!! \n\n");
            }
            else if (accounts2 is SavingAccount)
            {
                SavingAccount account6 = (SavingAccount) accounts2;
                account6.UpdateBalance();
                Console.WriteLine("UpdateBalance!!!\n\n");

            }





        }
    }
}
