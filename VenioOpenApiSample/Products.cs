using System;
using Newtonsoft.Json.Linq;
using RestSharp;
using Newtonsoft.Json;
using VenioOpenApiSample.Models;

namespace VenioOpenApiSample
{
	public class Products
	{
		public void CreateUpdateProduct(JToken access_token) {
            var option = new RestClientOptions("https://dev.tks.co.th/venio/api/gateway/v3/Products")
            { Timeout = -1};
            var client = new RestClient(option);
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Ocp-Apim-Subscription-Key", "<Ocp-Apim-Subscription-Key>");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer "+access_token);
            CreateUpdateProductRequest createUpdateProduct01 = new CreateUpdateProductRequest();
            createUpdateProduct01.Products = new Product[]
            {
               new Product{
               ProductCode="Li00001",
               ProductBarcode="",
               ProductName="Tissue Daisy",
               ProductDescription="Open API Test",
               Category="Open API",
               Cost=15,
               Prices=new ProductPrice[]{
                    new ProductPrice
                    {
                        PriceTierName="Normal Price",
                        RegularPrice=12.5,
                        SalePrice=15,
                        VatValue=3
                    }
               },
               ProductUnitName="API",
               TrackInventory=true,
               Qty=50,
               LowStockAlert=5,
               UseWarranty=false,
               Visibility=true,
               Active=true}
            };
            var body = JsonConvert.SerializeObject(createUpdateProduct01);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

	}
}

