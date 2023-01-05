using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenioOpenApiSample.Models;
using Newtonsoft.Json;
namespace VenioOpenApiSample
{
    public class Customer
    {
        public void CreateUpdate(JToken access_token)
        {

            var option = new RestClientOptions("https://dev.tks.co.th/venio/api/gateway/v3/customers")
            {
                Timeout = -1,
                UserAgent = "Apidog/1.0.0 (https://www.apidog.com)"
            };
            var client = new RestClient(option);
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Ocp-Apim-Subscription-Key", "<Ocp-Apim-Subscription-Key>");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + access_token);
            CreateUpdateCustomerRequest customerRequest01 = new CreateUpdateCustomerRequest();
            customerRequest01.CustomerName = "Daaisyy";
            customerRequest01.CustomerState = 3;
            customerRequest01.CustomerCode = "daisy";
            customerRequest01.CustomerStatus = 0;
            customerRequest01.CustomerType = 2;
            customerRequest01.CustomerGroupName = "CRM";
            customerRequest01.ClassificationName = "S";
            customerRequest01.CustomerBirthdate = "2000-06-04";
            customerRequest01.Addresses = new Address[] {
            new Address{
                LocationAddress="SamutSakhon",
                LocationName="samutSakhon",
                LocationType=2
            } };
            customerRequest01.SourceName = "Website";
            customerRequest01.CustomerSocialAccount = new CustomerSocialAccount
            {
                Facebook = ""
            };
            customerRequest01.LeadStatus = 4;
            customerRequest01.Contacts = new Contact[]{ new Contact{

                    ContactName="Contact002",
                    ContactBirthdate="2000-06-04",
                    ContactStatus=true,
                    ContactPosition="Intern"


            }};
            customerRequest01.Owners = new String[] { "Admin01" };
            var body = JsonConvert.SerializeObject(customerRequest01);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);

        }
        public void GetCustomerByCustomerId(JToken access_token)
        {
            var option = new RestClientOptions("https://dev.tks.co.th/venio/api/gateway/v3/customers/daisy")
            {
                Timeout = -1
            };
            var client = new RestClient(option);
            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("Ocp-Apim-Subscription-Key", "<Ocp-Apim-Subscription-Key>");
            request.AddHeader("Authorization", "Bearer " + access_token);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
