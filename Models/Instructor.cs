using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
  public class Instructor
  {
    public int ID { get; set; }

    [RequiredAttribute]
    [DisplayAttribute(Name = "Last Name")]
    [StringLengthAttribute(50)]
    public string LastName { get; set; }

    [RequiredAttribute]
    [ColumnAttribute("FirstName")]
    [DisplayAttribute(Name = "First Name")]
    [StringLengthAttribute(50)]
    public string FirstMidName { get; set; }

    [DataTypeAttribute(DataType.Date)]
    [DisplayFormatAttribute(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
    [DisplayAttribute(Name = "Hire Date")]
    public DateTime HireDate { get; set; }

    [DisplayAttribute(Name = "Full Name")]
    public string FullName
    {
      get { return LastName + ", " + FirstMidName; }
    }

    public ICollection<CourseAssignment> Courses { get; set; }
    public OfficeAssignment OfficeAssignment { get; set; }
  }
}