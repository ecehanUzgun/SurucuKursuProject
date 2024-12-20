﻿using MODEL.Concretes;

namespace MODEL.Entities
{
    public class Branch:BaseEntity
    {
        public string Name { get; set; }
        public string? Address { get; set; }
        public string PhoneNumber { get; set; } //todo:10 hane

        //Relational Properties
        public List<VehicleBranch> VehicleBranches { get; set; }
        public List<TeacherBranch> TeacherBranches { get; set; }
        public List<Student> Students { get; set; }
    }
}
