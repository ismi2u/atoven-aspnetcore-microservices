using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorRegistration.Application.Features.Queries
{

    public class BankDTO
    {
        public string Id { get; set; }
        public string Country { get; set; }
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string BankKey { get; set; }
        public string BankName { get; set; }
        public string SwiftCode { get; set; }
        public string BankAccount { get; set; }
        public string AccountHolderName { get; set; }
        public string IBAN { get; set; }
        public string Currency { get; set; }
    }
}
