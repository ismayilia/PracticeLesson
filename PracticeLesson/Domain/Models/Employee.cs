using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson.Models
{
    public class Employee: BaseEntity
    {
        // public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }


        public Employee()
        {
            
        }





    }
}
