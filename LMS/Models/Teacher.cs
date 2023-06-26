using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models
{
    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        public int TeacherName { get; set;}

        public int UserName { get; set; }

        public int Password { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Image { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime UpdateDate { get; set; } = DateTime.Now;

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public ICollection<Teacher> Teachers { get; set;}
    }
}
