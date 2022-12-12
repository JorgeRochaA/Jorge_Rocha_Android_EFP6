using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jorge_Rocha_Android_EFP6.Models
{
    public class AskStatus
    {
        public RestRequest request { get; set; }
        const string mimetype = "application/json";
        const string contentType = "Content-Type";

        public AskStatus() { }

        public int AskStatusId { get; set; }

        public string AskStatus1 { get; set; } = null!;

        public virtual ICollection<Ask> Asks { get; } = new List<Ask>();
    }
}
