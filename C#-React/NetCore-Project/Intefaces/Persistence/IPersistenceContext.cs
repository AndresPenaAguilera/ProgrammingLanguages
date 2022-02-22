using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intefaces.Persistence
{
    public interface IPersistenceContext
    {
        List<Course> GetCourses();
        void AddCourses(List<Course> courses);
        void Save();
    }
}
