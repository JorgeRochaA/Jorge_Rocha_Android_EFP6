using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Jorge_Rocha_Android_EFP6.Models.DTO
{
      public partial class UserDTO {
        public RestRequest request { get; set; }
        const string mimetype = "application/json";
        const string contentType = "Content-Type";

        public int UserId { get; set; }

        public string UserName { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public string UserPassword { get; set; } = null!;

        public int StrikeCount { get; set; }

        public string BackUpEmail { get; set; } = null!;

        public string? JobDescription { get; set; }

        public int UserStatusId { get; set; }

        public int CountryId { get; set; }

        public int UserRoleId { get; set; }

        public async Task<UserDTO> getUserData(int userId)
        {

            try
            {
                string RouteSufix = string.Format("Users/GetUserInfo?userId={0}",
                    userId);

                string FinalURL = Services.CnnToP6API.productionUrl + RouteSufix;

                RestClient client = new RestClient(FinalURL);


                request = new RestRequest(FinalURL, Method.Get);


                request.AddHeader(Services.CnnToP6API.apiKeyName, Services.CnnToP6API.apiKeyValue);
                request.AddHeader(contentType, mimetype);

                RestResponse response = await client.ExecuteAsync(request);

                HttpStatusCode statusCode = response.StatusCode;


                if (statusCode == HttpStatusCode.OK)
                {
                    var list = JsonConvert.DeserializeObject<List<UserDTO>>(response.Content);
                    var item = list[0];

                    return item;
                }
                else
                {
                    return null;
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
