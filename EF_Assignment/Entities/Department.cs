using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Entities
{
    internal class Department
    {

        public int Id { get; set; }

        public string? Name { get; set; }

        public DateTime HiringDate { get; set; }

        [ForeignKey(nameof(Manager))]
        public int ManagerId { get; set; }

        [InverseProperty(nameof(Instructor.ManageDepartment))]
        public Instructor Manager { get; set; }

       // [InverseProperty(nameof(Instructor.WorkForDepartment))]

        public ICollection<Instructor>Instructors=new  HashSet<Instructor>();
        public ICollection<Student> Students = new HashSet<Student>();




    }
}
