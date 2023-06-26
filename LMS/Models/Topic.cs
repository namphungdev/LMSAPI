using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS.Models
{
    [Table("Topic")]
    public class Topic
    {
        [Key]
        public int TopicId { get; set; }

        public string TopicName { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
