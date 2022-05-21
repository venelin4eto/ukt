using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_46272_r

{

    class Program
    {
//purvi kurs

        //zadacha 1
        public class Customer
        {
            public string firstName;
            public string lastName;
            public int age;
            public string status;


            public Customer(string firstName, string lastName, int age, string status)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.status = status;
            }


            public static void PrintCustomer(Customer a)
            {
                Console.WriteLine($" Your name is {a.firstName} {a.lastName} and you are a {a.age} years old {a.status}.");
            }


            //zadacha 2 
            public static void Check(int age, string status)
            {
                if (age <= 0)
                {
                    Console.WriteLine($"The age can't be {age}. Please enter valid number.");
                }
                else if (age > 0 && age <= 25)
                {
                    status = "student";
                }
                else if (age > 25 & age <= 65)
                {
                    status = "adult";
                }
                else
                {
                    status = "elder";
                }
            }






        }
    //zadacha 3

        public class SavingsAccount
        {
            public string owner;
            protected decimal balance;

            public void bankAccount(string name, decimal balance)
            {
                this.owner = name;
                this.balance = balance;
            }

            public void GetCredit(decimal creditAmount, Customer obj)
            {
                decimal totalCreditAmount;

                totalCreditAmount = creditAmount + creditAmount * (decimal)0.08;
                Console.WriteLine($"The Credit amount is ${totalCreditAmount} and the person is {obj.firstName} ");
            }

        }

        class CreditAccount : SavingsAccount
        {
           
        }


            static void Main(string[] args)
            {

                // dannite se vuvejdat ot konzolata
                Console.WriteLine("Please, enter your first name, last name and age.");
                Customer a1 = new Customer(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), null);
                if (a1.age <= 0)
                {
                    Console.WriteLine($"The age can't be {a1.age}. Please enter valid number.");
                }
                else if (a1.age > 0 && a1.age <= 25)
                {
                    a1.status = "student";
                }
                else if (a1.age > 25 && a1.age <= 65)
                {
                    a1.status = "adult";
                }
                else
                {
                    a1.status = "elder";
                }
                Customer.PrintCustomer(a1);
            


            }
        }
    }

