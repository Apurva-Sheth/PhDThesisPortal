using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhDThesisPortal.Models
{
    public class MyIdentityUser
        : IdentityUser<Guid>
    {

        [Display(Name = "Display Name")]
        [Required]
        [MinLength(3)]
        [StringLength(60)]
        public string DisplayName { get; set; }

        [Display(Name = "Gender")]
        [PersonalData]                                  // for GDPR Compliance.
        [Required]
        public string Gender { get; set; }

        [Display(Name = "Enrollment Number")]
        [StringLength(8, ErrorMessage = "{0} cannot have more than {1} character")]
        [MinLength(8, ErrorMessage = "{0} should have at least {1} character")]
        public string EnrollmentId { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Is User admin")]
        public bool IsAdminUser { get; set; } = false;

        #region Navigation Properties to the SubmissionDetails Model
        public ICollection<SubmissionDetail> SubmissionDetails { get; set; }
        #endregion
    }
}
