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
    public class Contact : EntityBase
    {

        [ForeignKey("CompanyID")]
        public virtual Company Company { get; set; }
        public int CompanyID { get; set; }

        [Required]
        [Column(TypeName = "varchar(150)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(150)")]
        public string LastName { get; set; }


        [Column(TypeName = "varchar(max)")]
        public string Address { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string Designation { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string Department { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string PhoneNo { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string MobileNo { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string FaxNo { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string Language { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string Country { get; set; }


    }

}
    
