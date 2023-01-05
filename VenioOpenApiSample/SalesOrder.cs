using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using VenioOpenApiSample.Models;

namespace VenioOpenApiSample
{
    public class SalesOrder
    {
        public void CreateUpdateSalesOrder(JToken access_token)
        {
            var option = new RestClientOptions("https://dev.tks.co.th/Venio/api/gateway/v2/salesorder")
            {
                Timeout = -1
            };

            var client = new RestClient(option);
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Ocp-Apim-Subscription-Key", "<Ocp-Apim-Subscription-Key>");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + access_token);
            CreateUpdateSalesOrderRequest salesOrder01 = new CreateUpdateSalesOrderRequest();
            salesOrder01.SalesOrderSubject = "consoleapp openapi";
            salesOrder01.CustomerCode = "daisy";
            salesOrder01.ReferenceNo = "Q01230000005";
            salesOrder01.SalesOrderDate = "2023-05-01";
            salesOrder01.SalesOrderDetails = new SalesOrderDetail[]
            {
                new SalesOrderDetail
                {
                    ProductCode="10001",
                   Qty=2

                }
            };
            salesOrder01.SalesOrderNo = "SO23010005";

            salesOrder01.VatCalculation = true;
            salesOrder01.SalesOrderStatus = 2;
            salesOrder01.StaffCode = "Admin01";
            var body = JsonConvert.SerializeObject(salesOrder01);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        public void GetSalesOrderBySalesOrderNo(JToken access_token)
        {
            var option = new RestClientOptions("https://dev.tks.co.th/Venio/Api/gateway/v2/salesorder/SO23010005");
            option.Timeout = -1;
            var client = new RestClient(option);
            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("Ocp-Apim-Subscription-Key", "<Ocp-Apim-Subscription-Key>");
            request.AddHeader("Authorization", "Bearer " + access_token);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        public void GetHeaderTemplate(JToken access_token)
        {
            var option = new RestClientOptions("https://dev.tks.co.th/Venio/api/gateway/v2/salesorder/headerTemplate");
            option.Timeout = -1;
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

