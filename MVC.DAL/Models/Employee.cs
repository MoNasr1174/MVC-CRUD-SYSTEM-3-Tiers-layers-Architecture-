using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DAL.Models
{
    public class Employee : BaseEntity
    {
   
  
        public string Name { get; set; }


        public int Age { get; set; }

        public String Address { get; set; }


        public decimal Salary { get; set; }


        public bool IsActive { get; set; }


        
        public string Email { get; set; }

       

        public string PhoneNumber { get; set; }

        
        public DateTime HireDate { get; set; }

        public bool ISDeleted { get; set; }

        

        public DateTime CreationTime { get; set; } = DateTime.Now;

        // Foreign Key
      //  [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        //  Navigation Property => {One}
      //  [InverseProperty("Employees")]
        public Department Department { get; set; }
        

    }
}
