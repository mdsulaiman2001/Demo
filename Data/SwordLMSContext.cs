using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SwordLMS.Web.Models;
namespace SwordLMS.Web.Data
{
    public class SwordLMSContext : DbContext 
    {
        public SwordLMSContext(DbContextOptions<SwordLMSContext>options ) 
            : base(options)

        {
        }
        
        public DbSet<City> City  { get; set; }

        public DbSet<ContentType> ContentTypes { get;set; }

        public DbSet<Country> Country { get; set; }

        public DbSet<Course> Course { get; set; }

        public DbSet<CourseContent> CourseContent { get; set; }
        
        public DbSet<CourseReview> courseReview { get; set; }

        public DbSet<CourseSkills> CourseSkills { get; set; }

        public DbSet<CourseTopics> CourseTopics { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<Skills> Skills { get; set; }

        public DbSet<State> State { get; set; }

        public DbSet<User> User { get; set; }
        
        public DbSet<UserContent> UserContent { get; set; }

        public DbSet<UserCourses> UserCourse { get; set; }


          

    }
}
