using EF_Assignment.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Configurations
{
    internal class InstructorCourseConfigurations : IEntityTypeConfiguration<InstructorCourse>
    {
        public void Configure(EntityTypeBuilder<InstructorCourse> builder)
        {
            builder.HasKey(Ic => new { Ic.CourseId, Ic.InstructorId });
        }
    }
}
