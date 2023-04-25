using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Class1
    {
    }

    public class ACustomer : ACustomerBase
    {
        public class CustomerID
        {
        }
    }

    public class clsCustomer
    {
        public int CustomerID;
        public DateTime CustomerDateOfBirth;

        public string CustomerName { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerGender { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmailAddress { get; set; }
        public double CustomerLoyaltyNumber { get; set; }

        private int customerID;

        public int GetCustomerID()
        {
            return customerID;
        }

        public void SetCustomerID(int value)
        {
            customerID = value;
        }

        public string Valid(string customerID, string customerFullName, string customerDateOfBirth, string customerGender, string customerFullAddress, string customerEmailAddress)
        {
            throw new NotImplementedException();
        }
    }
}
