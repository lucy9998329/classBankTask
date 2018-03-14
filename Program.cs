using System;

namespace classBankTask
{
    class Program
    {
        /*class Customer
        {
            private string _Username;
            private int _Id;

            
            public int BankLogin {get; set; }

            public Customer(string username, int id)
            {
                _Username = username;
                _Id = id;//we can access in the class without property (get and set) just putting the sign on the front of the name
            }

            public string Withdrawal()
            {
                
                //return $"hello my name is ${_Username} and I am ${_Id} years old";
                return $"Menu";
            }
            
               
        }*/


    public abstract class Account
{
    private Customer customer;
    private double balance;
    

    public Customer Customer { get; private set; }
    public double Balance { get; private set; }
   

    public Account(Customer customer, double balance, double interestRate)
    {
        this.Customer = customer;
        this.Balance = balance;
        
    }



    
    public virtual double Deposit(double amount)
    {
        return this.Balance + amount;
    }        
}



        static void Main(string[] args)
        {
            var jeff = new Customer("Jeff", 35);
            Console.WriteLine(jeff.Withdrawal());
        }
    }
}
