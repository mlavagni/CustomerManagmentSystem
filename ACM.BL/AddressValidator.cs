using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressValidator
    {   
       
        /// <summary>
        /// Validates the address data.
        /// </summary>
        /// <returns></returns>
        public bool Validate(string postalCode)
        {
            var isValid = true;

            if (postalCode == null) isValid = false;
            return isValid;
        }
    }
}
