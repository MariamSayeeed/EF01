using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    //EF Core : Supports 4 ways to map a class in DB[Table - View - Function]
    //1.By Convention[Default Behaviour]
    //2.Data Annotation[Set of attributes used for data validation]
    //3.FLuent APIs
    //4.Class Configuration

    //Entity
    //POCO
    //Plain Old CLR Object

    //Table
    //By Convention
    //internal class Employee // Table
    //{
    //    public int Id { get; set; } //Public numeric property [Id - EmployeeId] --> PK Identity Constraints
    //    public string Name { get; set; } // Reference Type : Required [Not Allow Null] - nvarchar(max) 
    //    public int? Age { get; set; } // Nullable type : int[Age] - Optional - [Allow Null]
    //    public double Salary { get; set; } //Value Type : Float [Salary]  - Required 
    //    public string? Address { get; set; }//Nullable reference type :  Optional
    //    public DateTime DateOfCreation { get; set; } //datetime2  - required 

    //}

    // 2. Data Annotation

    [Table("Employees", Schema = "dbo")]
    class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpId { get; set; }

        [Required]
        [Column(name: "EmpName", TypeName = "varchar")]
        [MaxLength(length: 50)]
        [StringLength(maximumLength: 50, MinimumLength = 10)]
        public string? Name { get; set; }

        [Range(minimum: 20, maximum: 60)] // Corrected Range attribute
        public int? Age { get; set; }

        [Column(TypeName = "money")]
        public double Salary { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } // Emp@example.com

        [Phone]
        public string PhoneNumber { get; set; }

        [NotMapped]
        public double TotalSalary { get; set; }

        public string Password { get; set; }
    }

}
