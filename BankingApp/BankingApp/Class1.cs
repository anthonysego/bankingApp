using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Customer
    {
        string customerFirstName;
        string customerLastName;
        int accountNum;
        double accountBal;

        //Default Constructor
        public Customer()
        {
        }

        public Customer(string first, string last, int acc, double bal)
        {
            customerFirstName = first;
            customerLastName = last;
            accountNum = acc;
            accountBal = bal;
        }

        public Customer(string first, string last, int acc)
        {
            customerFirstName = first;
            customerLastName = last;
            accountNum = acc;
            accountBal = 0;
        }


        //Property used to access or change Customer First Name
        public string CustomerFirstName { get; set; }

        //Property used to access or change Customer Last Name
        public string CustomerLastName { get; set; }

        //Property used to access or change Customer Account #
        public int AccountNum { get; set; }

        //Property used to access or change account balance
        public double AccountBal { get; set; }


        //Methods for deopsiting and withdrawing money into account balance
        public double DepositTo (double depositAmount)
        {
          accountBal = accountBal + depositAmount;
          return accountBal;
        }

        public double WithdrawalFrom (double withdrawAmount)
        {
          accountBal = accountBal - withdrawAmount;
          return accountBal;
        }

    }
}

