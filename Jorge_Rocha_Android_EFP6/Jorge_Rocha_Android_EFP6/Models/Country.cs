using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace Jorge_Rocha_Android_EFP6.Models
{
    public class Country
    {
        public RestRequest request { get; set; }
        const string mimetype = "application/json";
        const string contentType = "Content-Type";

        public Country() { }
        public int CountryId { get; set; }

        public string CountryName { get; set; } = null!;

        //public virtual ICollection<User> Users { get; } = new List<User>();
    }
}
