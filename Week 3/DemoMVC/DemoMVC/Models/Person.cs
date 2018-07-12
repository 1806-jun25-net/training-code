using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    // this is going to be our context model.
    // but we will write it.
    // should be a "POCO" "plain old CLR object"
    // need parameter-less contructor (usually default)
    // and public get-set properties
    public class Person
    {
        public int Id { get; set; }
<<<<<<< HEAD
        [Required]
=======

        [Required]
        [Display(Name = "First Name")]
        [StringLength(30, MinimumLength = 2)]
        [RegularExpression("")] // for more complicated matching
>>>>>>> master
        public string FirstName { get; set; }

        [Required]
        [Range(0, 150)]
        public int Age { get; set; }

        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; }

        // never bind this from form data
        //[BindNever]
        //public DateTime? DateCreated { get; set; }
    }
}
