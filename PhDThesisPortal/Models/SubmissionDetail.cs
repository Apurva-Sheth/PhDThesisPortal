using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhDThesisPortal.Models
{
    [Table("SubmissionDetails")]
    public class SubmissionDetail
    {
        [Display(Name = "Student Id")]
        [ForeignKey(nameof(SubmissionDetail.User))]      // foreign key to the object in the current model.
        public Guid Id { get; set; }           // User Id of the Project
        public MyIdentityUser User { get; set; }

        [Display(Name = "Faculty Id")]
        public string FacultyId { get; set; }

        [Display(Name = "Submission ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubmissionId { get; set; }

        [Display(Name ="Submission Description")]
        
        public string Description { get; set; }
        
        
        public string SubmissionFilePath { get; set; }
        [NotMapped]
        
        public IFormFile SubmissionFile { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Completion of Project")]
        public int CompletionPercentage { get; set; }
        public int status { get; set; } = 0;

        #region Navigation Properties to the Department Model 

        [Display(Name = "Department Name")]
        
        [ForeignKey(nameof(SubmissionDetail.Department))]      // foreign key to the object in the current model.
        public int DepartmentId { get; set; }           // department Id of the Subject

        public Department Department { get; set; }

        #endregion

        #region Navigation Properties to the Project Model
       // public ICollection<Project> Projects { get; set; }
        #endregion
    }
}
