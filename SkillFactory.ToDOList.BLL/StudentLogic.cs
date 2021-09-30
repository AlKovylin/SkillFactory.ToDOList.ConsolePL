using SkillFactory.ToDOList.BLL.Interface;
using SkillFactory.ToDOList.DAL.Interface;
using SkillFactory.ToDOList.Entities;
using System;
using System.Collections.Generic;

namespace SkillFactory.ToDOList.BLL
{
    public class StudentLogic : IStudentLogic
    {
        private readonly IStudentDao _studentDao;

        public StudentLogic(IStudentDao studentDao)
        {
            _studentDao = studentDao;
        }
            
        public int Add(Student student)
        {
            if(student.FirstName.Length < 3)
            {
                throw new ArgumentException("FirstName.Length > 3");
            }
            return _studentDao.Add(student);
        }

        public IEnumerable<Student> GetAll()
        {
            //throw new NotImplementedException();
            return _studentDao.GetAll();
        }

        public Student GetById(int id)
        {
            //throw new NotImplementedException();
            if(id < 0) { throw new ArgumentException("id < 0"); }
            return _studentDao.GetById(id);
        }
    }
}
