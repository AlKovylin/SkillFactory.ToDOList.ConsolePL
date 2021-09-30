using Microsoft.Extensions.Configuration;
using SkillFactory.ToDOList.BLL;
using SkillFactory.ToDOList.BLL.Interface;
using SkillFactory.ToDOList.DAL;
using SkillFactory.ToDOList.Entities.Configuration;
using SkillFactory.ToDOList.Ioc;
using System;
using System.IO;

namespace SkillFactory.ToDOList.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();
            var configurationDal = configuration.GetSection("configurationDal").Get<ConfigurationDAL>();
            var dr = new DependencyResolver(configurationDal);

            IStudentLogic studentLogic = dr.StudentLogic;
            
            var id = studentLogic.Add(new Entities.Student
            {
                FirstName = "Ivan",
                LastName = "Ivanov",
                Marks = new System.Collections.Generic.List<int>
                {
                    2, 2
                }
            });           

            var student = studentLogic.GetById(id);
            Console.WriteLine(student.FirstName);
        }
    }
}
