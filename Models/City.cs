namespace SwordLMS.Web.Models
{
    public class City
    {
        public  int Id{ get; set; }

        public string CityName { get; set; }

        public int StateId{ get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
    }
}
