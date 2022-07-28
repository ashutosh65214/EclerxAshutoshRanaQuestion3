using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EclerxAshutoshRanaQuestion3.Models
{
    public class Company
    {
        [Display(Name ="Supplier Id")]
        [Key]
        public int SupplierId { get; set; }

        [Required(ErrorMessage ="Company name Cannot be empty")]
        [Display(Name ="Company Name")]
        public string CompanyName { get; set; }
        [Display(Name ="Contact Name")]
        public string ContactName { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "PinCode Required")]
        [Display(Name = "PinCode")]
        public string PinCode { get; set; }

        [Index("Ix_MobileNo",IsUnique =true)]
        [Column(TypeName ="varchar")]
        [StringLength (12)]
        [Required(ErrorMessage = "Mobile nuber required")]
        [Display(Name = "Mobile Number")]
        public string MobileNo { get; set; }

        [Index("Ix_Email", IsUnique = true)]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        [Required(ErrorMessage = "Email required")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Display(Name = "Modified Date")]
        public DateTime? ModdifiedDate { get; set; }
    }
}