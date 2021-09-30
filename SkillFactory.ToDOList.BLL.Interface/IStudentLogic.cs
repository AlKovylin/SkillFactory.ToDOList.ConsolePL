using SkillFactory.ToDOList.Entities;
using System;
using System.Collections.Generic;

namespace SkillFactory.ToDOList.BLL.Interface
{
    public interface IStudentLogic
    {
        int Add(Student student);
        IEnumerable<Student> GetAll();
        Student GetById(int id);
    }
}
