using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenioOpenApiSample.Models;

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
            var body = @"{
              ""customerName"": ""newCustomerOpenApi04jan2022P4"", 
              ""customerState"": ""3"", 
                         // ""customerStatus"": ""0"", 
              //""customerType"": ""2"",

             // ""customer2ndName"": ""ng"", 
            /*  ""customerAliases"": [
                ""testOpenApi""
              ], */

            //  ""customerPhone"": ""+66660018286"", 
            //  ""customerMobile"": ""+66660018286"", 

            //  ""customerPosition"": ""staff"",  
             // ""customerGender"": ""2"",
            //  ""customerMaritalStatus"": ""2"", 
             // ""customerBirthdate"": ""2000-06-04"", 
             // ""customerIncome"": ""50000"",
             // ""addresses"": [
              //  {
              //    ""locationAddress"": ""samutsakhon"",
               //   ""locationName"": ""samutsakhon"", 
                //  ""locationType"": ""2"", 
               //   ""latitude"": ""0.00"", 
              //    ""longitude"": ""20.34""
               // }
             // ],
             // ""sourceName"": ""facebook"", 
             // ""customerGroupName"": ""test"", 
             // ""leadStatus"": ""1"",
             // ""unqulifiedReasonName"" : ""test"",
            //  ""unqulifiedReasonNote"" : ""test"", 
             /* ""interestsName"": [

              ],*/
            /*  ""customerTags"": [
   
              ],*/
             // ""classificationName"": ""VIP"", 

              //""contacts"":[ {
              //  ""contactName"": ""test01"", 
              //  ""contactStatus"": ""true"",

              //  ""contactPhone"": ""1234567890"", 
              //  ""contactMobile"": ""1234567890"", 
              //  ""contactEmail"": ""notuse"", 
               // ""contactPosition"": ""intern"", 
             //   ""contactBirthdate"": ""2000-06-04"", 
               // ""contactNote"": ""test open api""
             // }],
              //""customerSocialAccount"": {
              //  ""facebook"": ""notuse"",

              //}, 
            //""customerTaxNo"":""0000000000111"",
            //""customerNote"":""create for test"",
            /*  ""owners"": [
            ""Admin01""
              ]*/
        }";
            request.AddParameter("application/json", body,ParameterType.RequestBody);
             RestResponse response = client.Execute(request);
      
            Console.WriteLine(response.Content);
        
        }
    }
}
