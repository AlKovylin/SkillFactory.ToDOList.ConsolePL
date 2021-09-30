using SkillFactory.ToDOList.Entities;
using System;
using System.Collections.Generic;

namespace SkillFactory.ToDOList.DAL.Interface
{
    public interface IStudentDao
    {
        int Add(Student student);
        IEnumerable<Student> GetAll();
        Student GetById(int id);
    }
}
