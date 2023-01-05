
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
            // createCustomer01.CreateUpdate(accessToken);
            // createCustomer01.GetCustomerByCustomerId(accessToken);

            Quotation quotation01 = new Quotation();
            // quotation01.Enquiry(accessToken);
            // quotation01.CreateUpdateQuotation(accessToken);
            // quotation01.ConvertToSalesOrder(accessToken);

            Products product01 = new Products();
            // product01.CreateUpdateProduct(accessToken);
            // product01.GetTicketId(accessToken);
            //product01.GetProductByProductCode(accessToken);
            //product01.GetProducts(accessToken);

            SalesOrder salesOrder01 = new SalesOrder();
            //salesOrder01.CreateUpdateSalesOrder(accessToken);
            //salesOrder01.GetSalesOrderBySalesOrderNo(accessToken);
            //salesOrder01.GetHeaderTemplate(accessToken);
        }
    }
}