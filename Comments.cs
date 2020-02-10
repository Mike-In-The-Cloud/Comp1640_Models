using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // need these imports for data annotations 
using System.ComponentModel.DataAnnotations.Schema; // need these imports for data annotations


namespace project.Models
{
    public class Comments
    {
        // todo
        // enter this into the AppDbContext
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        

        public string Comment { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public Ideas Ideas { get; set; }
    }
}

