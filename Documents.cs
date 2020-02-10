using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // need these imports for data annotations 
using System.ComponentModel.DataAnnotations.Schema; // need these imports for data annotations


namespace project.Models
{
    /// <summary>
    /// 
    /// documents model
    /// has a relationship with the ideas model
    /// 
    /// </summary>
    public class Documents
    {
        // todo
        // enter this into the AppDbContext
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "int")]

        public string DocumentPath { get; set; }
        [Column(TypeName ="nvarchar(max)")]

        public Ideas Ideas { get; set; }
    }
}
