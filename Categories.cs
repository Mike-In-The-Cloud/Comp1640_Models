using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // need these imports for data annotations 
using System.ComponentModel.DataAnnotations.Schema; // need these imports for data annotations

namespace project.Models
{
    // categories table
    public class Categories
    {
        [Key]
        public int CategoriesId { get; set; } // Categories primary key
        [Column(TypeName = "int")]

        public string CategoryName { get; set; } // department name
        [Column(TypeName = "nvarchar(1000)")]
        [Required(ErrorMessage = "* Required")]
        [StringLength(256, ErrorMessage = "Must be less than 1000 Characters")]

        public ICollection<CategoriesToDepartmets> CategoriesToDepartmets { get; set; }
    }
}
