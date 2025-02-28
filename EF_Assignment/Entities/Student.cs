using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string ?LastName { get; set; }

        public string ?Address { get; set; }

        public int ?Age { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<StudentCourse> Students { get; set; }= new HashSet<StudentCourse>();






    }
}
