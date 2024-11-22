﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities;

namespace DAL.Configurations
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            //Id veritabanına gönderilirken engellenecek.
            builder.Ignore(x => x.ID);

            // StudentId ve TeacherId Composite Key olarak tanımlandı
            builder.HasKey(x => new { x.StudentId, x.TeacherId });

            //Foreign Key - Student
            //builder.HasOne(x => x.Student)
            //       .WithMany(x => x.Schedules)
            //       .HasForeignKey(x => x.StudentId);
                   
            // Foreign Key - Teacher
            //builder.HasOne(x => x.Teacher)
            //       .WithMany(x => x.Schedules)
            //       .HasForeignKey(x => x.TeacherId);
        }
    }
}
