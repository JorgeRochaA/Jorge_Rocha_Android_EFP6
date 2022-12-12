using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Jorge_Rocha_Android_EFP6.Models
{
    public class Ask
    {
        public RestRequest request { get; set; }
        const string mimetype = "application/json";
        const string contentType = "Content-Type";

        public long AskId { get; set; }

        public DateTime Date { get; set; }

        public string AskDescription { get; set; } = null!;

        public int UserId { get; set; }

        public int AskStatusId { get; set; }

        public bool? IsStrike { get; set; }

        public string? ImageUrl { get; set; }

        public string? AskDetail { get; set; }

        //public virtual ICollection<Answer> Answers { get; } = new List<Answer>();

        public virtual AskStatus AskStatus { get; set; } = null!;

        public virtual User User { get; set; } = null!;

        public async Task<bool> AddAsk()
        {
            try
            {
                string RouteSufix = string.Format("Asks");
                string FinalURL = Services.CnnToP6API.productionUrl + RouteSufix;

                RestClient client = new RestClient(FinalURL);

                request = new RestRequest(FinalURL, Method.Post);

                //agregar la info de segueridad del api, en este caso api key
                request.AddHeader(Services.CnnToP6API.apiKeyName, Services.CnnToP6API.apiKeyValue);
                request.AddHeader(contentType, mimetype);

                //serializar la clase para poder enviarla al api
                var settings = new JsonSerializerSettings();
                settings.NullValueHandling = NullValueHandling.Ignore;

                string SerialClass = JsonConvert.SerializeObject(this, settings);

                request.AddBody(SerialClass, mimetype);

                RestResponse response = await client.ExecuteAsync(request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.Created)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw;
            }
        }
    }
}
