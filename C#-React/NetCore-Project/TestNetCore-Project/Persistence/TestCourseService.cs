using Domain;
using Intefaces.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence;
using Resolver;
using System;
using System.Collections.Generic;

namespace TestNetCore_Project
{
    [TestClass]
    public class TestCourseService
    {
        IPersistenceContext _IPersistenceContext;

        [TestInitialize]
        public void Initialize()
        {
            var services = new ServiceCollection();

            IServiceCollection service = new ServiceCollection(); //services.AddDbContext<OnlineCoursesContext>(option => option.UseInMemoryDatabase(databaseName: "InMemory" + Guid.NewGuid().ToString()));
            service.AddScoped<IConstructorConexion, ConstructorConexionTest>();
            service.RegistrarContexto<IPersistenceContext,OnlineCoursesContext>();

            //service.AddServices();
         

            IServiceProvider serviceProvider = service.BuildServiceProvider();

            _IPersistenceContext = serviceProvider.GetService<IPersistenceContext>();
        }

        [TestMethod]
        public void Must_GetCourses_ReturnListCourses()
        {
            List<Course> courses = new List<Course>()
            {
                new Course()
                {
                    Title="nUEVOP sqL",
                    Description="Orteo",
                    PublicationDate = DateTime.Now

                },
                new Course()
                {
                    Title="nUEVOP sqL2",
                    Description="Orteo",
                    PublicationDate = DateTime.Now

                }
            };

            _IPersistenceContext.AddCourses(courses);
            _IPersistenceContext.Save();

            var List = _IPersistenceContext.GetCourses();
            Assert.AreEqual(List.Count,2);
        }
    }
}
