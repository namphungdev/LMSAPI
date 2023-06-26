using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string CourseName { get; set;}

        public int TeacherId { get; set;}

        public Teacher Teacher { get; set;}

        public ICollection<Topic> Topic { get; set; }
    }
}
