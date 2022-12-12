using RestSharp;
using System;

namespace Jorge_Rocha_Android_EFP6.Models
{
    public class Item
    {
        public RestRequest request { get; set; }
        const string mimetype = "application/json";
        const string contentType = "Content-Type";

        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}