using ACM.Models;
using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        //this constructor will call the other constructor
        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
           CustomerId = customerId;
           AddressList = new List<Address>();
        }


        public List<Address> AddressList { get; set; }

        public int CustomerId { get; private set; }

        public int CustumerType { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public static int InstantCount { get; set; }


        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                fullName += FirstName;
                }
                return fullName;
            }
        }

        
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;

            return isValid;

        }
        public string Log() => 
            $"{CustomerId}: {FullName}: {EmailAddress}: {EntityState.ToString()}";

    
    }
}
