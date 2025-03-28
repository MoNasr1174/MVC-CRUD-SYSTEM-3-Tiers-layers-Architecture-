﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DAL.Models
{
    public class Employee : BaseEntity
    {
     

        [Required(ErrorMessage = "The Name Is Required")]
        [MaxLength(50 , ErrorMessage = "MaxLength For Name IS 50 Chars")]
        [MinLength(5,ErrorMessage = "MinLength FOr Name IS 5 Chars")]
        public string Name { get; set; }

        [Range(22, 30)]
        public int Age { get; set; }

        //[RegularExpression("^[0-9]{1,3}-[a-zA-Z]{4,10}-[a-zA-Z]{5,10}$",
         //ErrorMessage ="Address Must Be Like 123-street-city-country")]
        public String Address { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [Display(Name = "IS Active")]
        public bool IsActive { get; set; }

        [EmailAddress]
        
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone Number")]

        public string PhoneNumber { get; set; }

        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        public bool ISDeleted { get; set; }

        [Display(Name = "Creation Time")]

        public DateTime CreationTime { get; set; }


    }
}
