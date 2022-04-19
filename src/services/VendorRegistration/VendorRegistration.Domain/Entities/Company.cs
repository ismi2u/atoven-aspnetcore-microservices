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
    public class Company : EntityBase
    {

        public string CompanyName { get; set; }

        public string CommercialRegistrationNo { get; set; }

        public string Language { get; set; }

        public string Email { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string Country { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string Region { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string District { get; set; }


        //[Column(TypeName = "varchar(20)")]
        //public string PostalCode { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string City { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string Street { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string HouseNo { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string Building { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string Floor { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string Room { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string? POBox { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string PhoneNo { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string FaxNumber { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string Email { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string MobileNo { get; set; }


        //[Column(TypeName = "varchar(200)")]
        //public string Website { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string VendorType { get; set; }


        //[Column(TypeName = "varchar(200)")]
        //public string AccountGroup { get; set; }


        //[Column(TypeName = "varchar(max)")]
        //public string Notes { get; set; }


        //[Column(TypeName = "varchar(100)")]
        //public string VatNo { get; set; }

        //public string DocumentIDs { get; set; }


        //public bool? IsVendorInitiated { get; set; }
        //public DateTime RecordDate { get; set; }
        //public bool IsApproved { get; set; }
        //public DateTime? ApprovedDate { get; set; }


        //public List<Contact> ListOfCompanyContacts { get; set; }

        //public List<Bank> ListOfCompanyBanks { get; set; }
    }

}
