using EF_Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Configurations
{

    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasOne(c=>c.Topic).WithMany(T=>T.Courses)
                .HasForeignKey(c=>c.TopicId).IsRequired(false)
                .OnDelete(deleteBehavior:DeleteBehavior.Cascade);
        }
    }

}
