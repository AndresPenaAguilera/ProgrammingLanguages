using Domain;
using Intefaces.Application;
using Intefaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Courses
{
    public class Queries : IQuerys
    {
        private readonly IPersistenceContext _persistenceContext;
        public Queries(IPersistenceContext persistenceContext) 
        {
            _persistenceContext = persistenceContext;
        }

        public List<Course> GetCourses() 
        {
            return _persistenceContext.GetCourses();
        }
    }
}
