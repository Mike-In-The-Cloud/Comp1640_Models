using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // need these imports for data annotations 
using System.ComponentModel.DataAnnotations.Schema; // need these imports for data annotations


namespace project.Models
{
    public class Reports
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "int")]

        public string Type { get; set; }
        [Column(TypeName = "nvarchar(256)")]

        public string Description { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public Ideas Ideas { get; set; }
    }
}
