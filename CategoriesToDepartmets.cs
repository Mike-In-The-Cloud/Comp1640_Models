using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // need these imports for data annotations 
using System.ComponentModel.DataAnnotations.Schema; // need these imports for data annotations

namespace project.Models
{
    // link table from categories to departments
    public class CategoriesToDepartmets
    {
        [Key]
        public int Id { get; set; }

        // departments foreign key
        public Departments Departments { get; set; }
        public Categories Categories { get; set; }
    }
}
