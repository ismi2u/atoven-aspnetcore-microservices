using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRegistration.Domain.Common;

namespace VendorRegistration.Domain.Entities
{
    public class Bank : EntityBase
    {

        public virtual Company Company { get; set; }
        public int CompanyID { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string Country { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string BankKey { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string BankName { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string SwiftCode { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string BankAccount { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string AccountHolderName { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string IBAN { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string Currency { get; set; }
    }


}
