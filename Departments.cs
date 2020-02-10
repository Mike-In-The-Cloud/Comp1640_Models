using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // need these imports for data annotations 
using System.ComponentModel.DataAnnotations.Schema; // need these imports for data annotations 
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    // department model
    public class Departments
    {
        [Key]
        public int DeparmentId { get; set; } // departments primary key
        [Column(TypeName = "int")]

        public string DepartmentName { get; set; } // department name
        [Column(TypeName = "nvarchar(1000)")]
        [Required(ErrorMessage = "* Required")]
        [StringLength(256, ErrorMessage = "Must be less than 1000 Characters")]

        public ICollection<CategoriesToDepartmets> CategoriesToDepartmets { get; set; }
    }
}
