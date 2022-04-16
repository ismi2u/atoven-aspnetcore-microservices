

namespace VendorRegistration.Application.Features.Queries
{
 
        public class CompanyDTO
        {
            public Guid Id { get; set; }
            public string CompanyName { get; set; }
            public string CommercialRegistrationNo { get; set; }
            public string Language { get; set; }
            public string Country { get; set; }
            public string Region { get; set; }
            public string District { get; set; }
            public string PostalCode { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public string HouseNo { get; set; }
            public string Building { get; set; }
            public string Floor { get; set; }
            public string Room { get; set; }
            public string? POBox { get; set; }
            public string PhoneNo { get; set; }
            public string FaxNumber { get; set; }
            public string Email { get; set; }
            public string MobileNo { get; set; }
            public string Website { get; set; }
            public string VendorType { get; set; }
            public string AccountGroup { get; set; }
            public string Notes { get; set; }
            public string VatNo { get; set; }

            //public string DocumentIDs { get; set; }

            public bool? IsVendorInitiated { get; set; }
            public DateTime RecordDate { get; set; }
            public bool IsApproved { get; set; }
            public DateTime? ApprovedDate { get; set; }

            //public List<ContactDTO> ListOfCompanyContacts { get; set; }

            //public List<BankDTO> ListOfCompanyBanks { get; set; }

    }
}
