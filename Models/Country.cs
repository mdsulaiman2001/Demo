using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace SwordLMS.Web.Models
{
    public class Country
    {
        public int id { get; set; }

        public string CountryName { get; set; }

        public  bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

    }
}
