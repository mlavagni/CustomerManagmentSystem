using ACM.DataAccess;
using ACM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressProcessor
    {
        public List<Address> GetAddressesByClientId(int clientId)
        {
            AddressRepository addressRepository = new AddressRepository();
            return addressRepository.RetriveByCustomerId(clientId).ToList();
           
        }
        
    }
}
