namespace SwordLMS.Web.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string name { get; set; }
        public string description { get; set; } 
        public int authorId { get; set; }

        public int duration { get; set; }

        public int MainSkillsId  { get; set;}

        public DateTime DateOfPublish { get; set; }

        public int ratings { get; set; }    



    }
}
