using SkillFactory.ToDOList.BLL;
using SkillFactory.ToDOList.BLL.Interface;
using SkillFactory.ToDOList.DAL;
using SkillFactory.ToDOList.DAL.Interface;
using SkillFactory.ToDOList.Entities.Configuration;
using System;

namespace SkillFactory.ToDOList.Ioc
{
    public class DependencyResolver
    {
        public IStudentDao studentDao;
        public IStudentLogic StudentLogic { get; }

        public DependencyResolver(ConfigurationDAL configurationDAL)
        {
            studentDao = GetStudentDaoByType(configurationDAL.Type);
            StudentLogic = new StudentLogic(studentDao);
        }

        private IStudentDao GetStudentDaoByType(TypeOfDao typeOfDao)
        {
            switch (typeOfDao)
            {
                case TypeOfDao.File:
                    return null;
                case TypeOfDao.Memory:
                    return new StudentDao();
                default:
                    throw new ArgumentException("Can't resolve type for StudentDao");
            }
        }

    }
}
