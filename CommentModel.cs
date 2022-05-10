using System;
using System.ComponentModel.DataAnnotations;

namespace Connected.Models
{
    public class CommentModel
    {
        [Display(Name="Name")]
        [Required]
        public string Name {get;  set;}
         
         [Display(Name="Email")]
        [Required]
        public string Email {get;  set;}
         

        [Display(Name="Title")]
        [Required]
        public string Title {get;  set;}
         

        [Display(Name="Comments")]
        [Required]
        public string Comments {get;  set;}
         


    }
}