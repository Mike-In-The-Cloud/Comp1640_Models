using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // need these imports for data annotations 
using System.ComponentModel.DataAnnotations.Schema; // need these imports for data annotations


namespace project.Models
{
    public class Ideas
    {
        // todo
        // enter this into the AppDbContext 
        // add relationships to user

        [Key]
        public int IdeasId { get; set; } // Categories primary key
        [Column(TypeName = "int")]

        public string CreateDate { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        [Required(ErrorMessage = "* Required")]
        [StringLength(256, ErrorMessage = "")]



        public string Status { get; set; }
        [Column(TypeName ="nvarchar(42")]
        [Required(ErrorMessage ="* Required")]


        public string Title { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        [Required(ErrorMessage ="* Title Required")]

        public string ShortDescription { get; set; }
        [Column(TypeName = "nvarchar(256")]
        // [Required(ErrorMessage = "* Required")] // not sure if this is required can be added in if it is
       
        public int ThumbUp { get; set; }
        public int ThumbDown { get; set; }

        public string CloseDate { get; set; }
        [Column(TypeName = "nvarchar(30)")]

        public string FinalClosure { get; set; }
        [Column(TypeName = "nvarchar(30)")]

        public bool DisplayAnonymous { get; set; }
        [Column(TypeName ="bit")]



        

        public ICollection<CategoriesToIdeas> CategoriesToIdeas { get; set; }
        public ICollection<Documents> Documents { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public ICollection<Reports> Reports { get; set; }
    }
}
