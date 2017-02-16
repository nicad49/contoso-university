using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
  public class OfficeAssignment
  {
    [KeyAttribute]
    [ForeignKeyAttribute("Instructor")]
    public int InstructorID { get; set;  }
    [StringLengthAttribute(50)]
    [DisplayAttribute(Name = "Office Location")]
    public string Location { get; set; }
    public virtual Instructor Instructor { get; set; }
  }
}