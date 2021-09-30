using System;
using System.Collections.Generic;

namespace SkillFactory.ToDOList.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Marks { get; set; }
    }
}
