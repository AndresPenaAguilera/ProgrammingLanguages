using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public partial class OnlineCoursesContext
    {
        public List<Course> GetCourses()
        {
            return Course.ToList();
        }

        public void AddCourses(List<Course> courses) 
        {
            Course.AddRange(courses);
        }
    }
}
