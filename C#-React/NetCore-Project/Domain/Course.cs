using System;
using System.Collections.Generic;
namespace Domain
{
    public class Course
    {
        public int CourseId {get; set;}
        public string Title {get; set;}
        public string Description {get; set;}
        public DateTime PublicationDate {get; set;}
        public byte[] CoverPhoto {get; set;}
        public Price promotionPrice {get; set;}
        public ICollection<Comment> ListComment{get; set;}
        public ICollection<CourseInstructor> LinkInstructors {get; set;}
    }
}