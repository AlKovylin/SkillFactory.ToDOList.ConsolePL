using SkillFactory.ToDOList.DAL.Interface;
using SkillFactory.ToDOList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillFactory.ToDOList.DAL
{
    public class StudentDao: IStudentDao
    {
        public int Add(Student student)
        {
            int id = GetLastId() + 1;
            student.Id = id;
            MemoryDao.students.Add(id, student);
            return id;
        }

        private int GetLastId()
        {
            int lastId;
            if (MemoryDao.students.Count == 0)
            {
                lastId = 0;
            }
            else
            {
                lastId = MemoryDao.students.Keys.Max();
            }
            return lastId;
        }

        public IEnumerable<Student> GetAll()
        {
            return MemoryDao.students.Values.ToList();
        }

        public Student GetById(int id)
        {
            if(!MemoryDao.students.TryGetValue(id, out var student))
            {
                return null;
            }
            return student;
        }
    }
}
