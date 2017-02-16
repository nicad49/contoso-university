using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
  public class Department
  {
    public int DepartmentID { get; set; }

    [StringLengthAttribute(50, MinimumLength = 3)]
    public string Name { get; set; }

    [DataTypeAttribute(DataType.Currency)]
    [ColumnAttribute(TypeName = "money")]
    public decimal Budget { get; set; }

    [DataTypeAttribute(DataType.Date)]
    [DisplayFormatAttribute(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
    [DisplayAttribute(Name = "Start Date")]
    public DateTime StartDate { get; set; }

    public int? InstructorID { get; set; }
    public Instructor Administrator { get; set; }
    public ICollection<Course> Courses { get; set; }
  }
}