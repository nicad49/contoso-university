using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
  public class Student
  {
    public int ID { get; set; }
    
    [Required]
    [StringLength(50)]
    [Display(Name = "Last Name")]
    [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
    public string LastName { get; set; }
    
    [Required]
    [StringLength(50, ErrorMessage = "No one's first name is longer than 50 characters...come on!")]
    [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
    [Column("FirstName")]
    [Display(Name = "First Name")]
    public string FirstMidName { get; set; }
    
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
    [Display(Name = "Enrollment Date")]
    public DateTime EnrollmentDate { get; set; }
    public string FullName
    {
      get 
      {
        return LastName + ", " + FirstMidName;
      }
    }
    public ICollection<Enrollment> Enrollments { get; set; }
  }
}