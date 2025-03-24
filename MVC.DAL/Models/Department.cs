﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DAL.Models
{
    public class Department
    {
        public int  Id { get; set; }

        [Required(ErrorMessage ="Code Is Required")]
        public int Code { get; set; }

        [Required(ErrorMessage = "Code Is Required")]

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateOfCreation { get; set; }

    }
}
