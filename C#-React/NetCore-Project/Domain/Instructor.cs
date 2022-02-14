using System.Collections.Generic;

namespace Domain
{
    public class Instructor
    {
        public int InstructorId {get; set;}
        public string Name {get; set;}
        public string LastName {get; set;}
        public string Grade {get; set;}
        public byte[] ProfilePhoto{get; set;}
        public ICollection<CourseInstructor> LinkCurse{get; set;}
    }
}