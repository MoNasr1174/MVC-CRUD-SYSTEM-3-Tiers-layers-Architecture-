﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DAL.Models
{
    public class Department : BaseEntity
    {


        [Required(ErrorMessage = "Code Is Required")]

        public int Code { get; set; }

        [Required(ErrorMessage = "Code Is Required")]

        public string Name { get; set; }

        [Display(Name = "Date Of Creation")]
        public DateTime DateOfCreation { get; set; }

        // Navigation Property => {Many}
       // [InverseProperty("Department")]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

    }
}
