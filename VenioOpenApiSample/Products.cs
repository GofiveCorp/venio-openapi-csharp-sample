using System;
using Newtonsoft.Json.Linq;
using RestSharp;
using Newtonsoft.Json;
using VenioOpenApiSample.Models;
using Attribute = VenioOpenApiSample.Models.Attribute;

namespace VenioOpenApiSample
{
    public class Products
    {
        public void CreateUpdateProduct(JToken access_token)
        {
            var option = new RestClientOptions("https://dev.tks.co.th/venio/api/gateway/v3/Products")
            { Timeout = -1 };
            var client = new RestClient(option);
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Ocp-Apim-Subscription-Key", "<Ocp-Apim-Subscription-Key>");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + access_token);
            // single product
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
                        VatValue=3,
                        UseDefaultVat=true
                    }
               },
               ProductUnitName="API",
               TrackInventory=true,
               Qty=50,
               LowStockAlert=5,
               UseWarranty=false,
               Visibility=true,
               Active=true,


               }
            };

            // multiple product 
            CreateUpdateProductRequest createUpdateProduct02 = new CreateUpdateProductRequest();
            createUpdateProduct02.Products = new Product[]
            {
               new Product{

               ProductBarcode="",
               ProductName="Tissue Daisy",
               ProductDescription="Open API Test",
               Category="Open API",
               SubCategory="SKU",
               ProductUnitName="API",
               TrackInventory=true,
               UseWarranty=false,
               Visibility=true,
               Active=true,
               ProductVariant=new ProductVariant[]
               {
                   new ProductVariant
                   {
                       ProductCode="LI00002",
                       ProductName="TestMobilePhone",
                       Cost=18500,
                       Qty=34,
                       LowStockAlert=5,
                       Prices=new ProductPrice[]
                       {
                        new ProductPrice
                        {
                        PriceTierName="Normal Price",
                        RegularPrice=12.5,
                        SalePrice=20000,

                        }
                       },
                       Attribute=new Attribute[]
                       {
                        new Attribute
                        {
                            AttributeName="Size",
                            AttributeValueName="16 GB"
                        }
                       }
                   }
               }

               }
            };

            var body = JsonConvert.SerializeObject(createUpdateProduct02);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        public void GetTicketId(JToken access_token)
        {
            var option = new RestClientOptions("https://dev.tks.co.th/Venio/api/gateway/tickets/280")
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
        public void GetProductByProductCode(JToken access_token)
        {
            var option = new RestClientOptions("https://dev.tks.co.th/Venio/api/gateway/v2/products/10001");
            option.Timeout = -1;
            var client = new RestClient(option);
            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("Ocp-Apim-Subscription-Key", "<Ocp-Apim-Subscription-Key>");
            request.AddHeader("Authorization", "Bearer " + access_token);
            request.AddHeader("Content-Type", "application/json");
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        public void GetProducts(JToken access_token)
        {
            var option = new RestClientOptions("https://dev.tks.co.th/Venio/api/gateway/v2/products/getproduct");
            option.Timeout = -1;
            var client = new RestClient(option);
            var request = new RestRequest();
            request.Method = Method.Post;
            ProductsRequest products = new ProductsRequest();
            products.Take = 5;
            products.Status = new int[] { 1 };
            request.AddHeader("Ocp-Apim-Subscription-Key", "<Ocp-Apim-Subscription-Key>");
            request.AddHeader("Authorization", "Bearer " + access_token);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(products);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}

