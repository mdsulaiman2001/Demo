
using System.ComponentModel.DataAnnotations;

namespace SwordLMS.Web.Models
{
    public class CourseSkills
    {
        [Key]
        public int CourseId { get; set; }

        public int SkillId { get; set; }    
    }
}
