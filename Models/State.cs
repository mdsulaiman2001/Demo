namespace SwordLMS.Web.Models
{
    public class State
    {
        public int Id { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
        public bool IsActive { get; set; }  
        public bool IsDeleted { get; set; }
    }
}


