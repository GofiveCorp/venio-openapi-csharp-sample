using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using VenioOpenApiSample.Models;

namespace VenioOpenApiSample
{
    public class Quotation
    {
        public void Enquiry(JToken access_token)
        {
            var option = new RestClientOptions("https://dev.tks.co.th/venio/api/gateway/v1/quotation/enquiry")
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
            QuotationRequest quotationRequest = new QuotationRequest();
            quotationRequest.Take = 4;
            //     quotationRequest.QuotationDate = "2022-12-16";
            //   quotationRequest.QuotationNo = "Q12220000110";
            //    quotationRequest.CustomerCode = "daisy";
            quotationRequest.QuotationStatus = 4;
            //   quotationRequest.Skip = 0;
            var body = JsonConvert.SerializeObject(quotationRequest);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            var dataResponse = response.Content;

            Console.WriteLine(dataResponse);


        }
        public void CreateUpdateQuotation(JToken access_token)
        {
            var option = new RestClientOptions("https://dev.tks.co.th/venio/api/gateway/v2/quotation")
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
            CreateUpdateQuotationRequest createUpdateQuotation01 = new CreateUpdateQuotationRequest();
            createUpdateQuotation01.QuotationSubject = "Test open api edit quotation openapi consoleapp";
            createUpdateQuotation01.QuotationStatus = 1;
            createUpdateQuotation01.CustomerCode = "daisy";
            createUpdateQuotation01.StaffCode = "Admin01";
            createUpdateQuotation01.VatCalculation = true;
            createUpdateQuotation01.ReferenceNo = "DRAFT2301000004";//ต้องกรอกเลขอ้างอิ้งใบ้เสนอราคาในกรณีที่เป็นการแก้ไข
            createUpdateQuotation01.QuotationDate = "2023-01-04";
            createUpdateQuotation01.QuotationValidUntil = "2023-02-04";
            createUpdateQuotation01.QuotationDetails = new QuotationDetail[]
            {
                new QuotationDetail
                {
                    ProductCode="AB00025dddd",
                    Qty=2,
                    DiscountType=false,
                    DiscountValue=10,
                }
            };

            var body = JsonConvert.SerializeObject(createUpdateQuotation01);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            var dataResponse = response.Content;

            Console.WriteLine(dataResponse);
        }
        public void ConvertToSalesOrder(JToken access_token)
        {
            var option = new RestClientOptions("https://dev.tks.co.th/venio/api/gateway/v1/quotation/Q01230000002/convert-to-salesorder")
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


            var quotationRequest = new QuotationConvertToSalesOrder();
            quotationRequest.QuotationNo = "Q01230000002";

            var body = JsonConvert.SerializeObject(quotationRequest);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            var dataResponse = response.Content;

            Console.WriteLine(dataResponse);

        }
    }
}

