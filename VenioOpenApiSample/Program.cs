
using Newtonsoft.Json.Linq;
using RestSharp;
using VenioOpenApiSample.Models;

namespace VenioOpenApiSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var option = new RestClientOptions("https://dev.tks.co.th/identityserver2/connect/token")
            {
                Timeout = -1,
                UserAgent = "Apidog/1.0.0 (https://www.apidog.com)"
            };
            var client = new RestClient(option);

            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddParameter("grant_type", "bypass");
            request.AddParameter("client_id", "teamvenio");
            request.AddParameter("client_secret", "7945e4cc-1aa6-4e5b-8c51-04115b3a2afe");
            request.AddParameter("username", "admin01@teamvenio.com");
            request.AddParameter("password", "1");
            request.AddParameter("scope", "openid profile GOFIVE.API IMC.API Venio2.API");
            RestResponse response = client.Execute(request);
            var dataResponse = JObject.Parse(response.Content);
            var accessToken = dataResponse?.First.First;
            Console.WriteLine(accessToken);
            Customer createCustomer01 = new Customer();
            CreateUpdateCustomerRequest customer01 = new CreateUpdateCustomerRequest();
            customer01.CustomerName = "openapi create new customer";
            customer01.CustomerState = "3";
            customer01.CustomerStatus = "0";
            customer01.CustomerType = "2";
            customer01.CustomerBirthdate = "2000-06-04";
            customer01.Addresses = new Address[]
            {
                new Address{
                    LocationAddress="samutsakhon",
                    LocationName="SamutSakhon",
                    LocationType="2",
                }
            };

            // createCustomer01.CreateUpdate(accessToken);
            Quotation quotation01 = new Quotation();
            //เส้นเรียกดูข้อมูลหลายๆชุด
            quotation01.Enquiry(accessToken);
            //เส้นสร้างแก้ไขข้อมูลใบ้เสนอราคา
            quotation01.CreateUpdateQuotation(accessToken);
            //เส้นการเปลี่ยนใบ้เสนอราคาให้กล้ายเป็นใบ้สั่งขาย
            quotation01.ConvertToSalesOrder(accessToken);
        }
    }
}