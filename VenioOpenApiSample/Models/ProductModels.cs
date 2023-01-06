using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace VenioOpenApiSample.Models
{

    /// <summary>
    /// Request
    /// </summary>
    public partial class CreateUpdateProductRequest
    {
        [JsonProperty("products")]
        public Product[] Products { get; set; }
    }

    public partial class Product
    {
        /// <summary>
        /// สถานะสินค้า [true = ใช้งาน , false = ไม่ใช้งาน]
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <summary>
        /// หมวดหมู่หลัก [ถ้ามีการส่งข้อมูลมาไม่ครงกับระบบ ทางระบบจะทำการสร้าง Category ให้]
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// ต้นทุนสินค้า [ระบบจะไม่ Required และไม่สนใจ ถ้าเป็น Multi SKU]
        /// </summary>
        [JsonProperty("cost", NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; }

        /// <summary>
        /// แจ้งเตือนเมื่อสต็อกคงเหลือ
        /// </summary>
        [JsonProperty("lowStockAlert", NullValueHandling = NullValueHandling.Ignore)]
        public long? LowStockAlert { get; set; }

        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public ProductPrice[] Prices { get; set; }

        /// <summary>
        /// รหัสบาร์โค้ด
        /// </summary>
        [JsonProperty("productBarcode", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductBarcode { get; set; }

        /// <summary>
        /// รหัสสินค้า [ไม่ต้องกรอก ถ้าเป็น multi-SKU]
        /// </summary>
        [JsonProperty("productCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductCode { get; set; }

        /// <summary>
        /// รายละเอียดสินค้า
        /// </summary>
        [JsonProperty("productDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductDescription { get; set; }

        /// <summary>
        /// รูปสินค้า ให้ส่งเป็น PublicUrl
        /// </summary>
        [JsonProperty("productImage", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ProductImage { get; set; }

        /// <summary>
        /// ชื่อสินค้า
        /// </summary>
        [JsonProperty("productName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// ป้ายกำกับสินค้า [ถ้าไม่ตรงกับในระบบ จะสร้าง productTag ให้ใหม่]
        /// </summary>
        [JsonProperty("productTag", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductTag { get; set; }

        /// <summary>
        /// หน่วยสินค้า [ถ้าใส่ค่า Unit ไม่ตรงกับระบบ จะแสดง error]
        /// </summary>
        [JsonProperty("productUnitName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductUnitName { get; set; }

        [JsonProperty("productVariant", NullValueHandling = NullValueHandling.Ignore)]
        public ProductVariant[] ProductVariant { get; set; }

        /// <summary>
        /// น้ำหนักสินค้า
        /// </summary>
        [JsonProperty("productWeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? ProductWeight { get; set; }

        /// <summary>
        /// หน่วยน้ำหนังสินค้า [ระบบ Default ให้ มี "gram" , "kilogram"]
        /// </summary>
        [JsonProperty("productWeightUnit", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductWeightUnit { get; set; }

        /// <summary>
        /// จำนวนสินค้า [เป็นจำนวนสินค้าของ Single Product]
        /// </summary>
        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public long? Qty { get; set; }

        /// <summary>
        /// หมวดหมู่ย่อย [ถ้ามีการส่งข้อมูลมาไม่ครงกับระบบ ทางระบบจะทำการสร้าง Category ให้]
        /// </summary>
        [JsonProperty("sub_SubCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string SubSubCategory { get; set; }

        /// <summary>
        /// หมวดหมู่รอง [ถ้ามีการส่งข้อมูลมาไม่ครงกับระบบ ทางระบบจะทำการสร้าง Category ให้]
        /// </summary>
        [JsonProperty("subCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCategory { get; set; }

        /// <summary>
        /// หน่วยเวลาการรับประกันสินค้า [y = year ,m = month ,d = day]
        /// </summary>
        [JsonProperty("timeWarrantyUnit", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeWarrantyUnit { get; set; }

        /// <summary>
        /// ระยะเวลาการรับประกันสินค้า
        /// </summary>
        [JsonProperty("timeWarrantyValue", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeWarrantyValue { get; set; }

        /// <summary>
        /// จัดการข้อมูลคลังสินค้า [true = อนุญาตให้จัดการ , false = ไม่อนุญาตให้จัดการ]
        /// </summary>
        [JsonProperty("trackInventory", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TrackInventory { get; set; }

        /// <summary>
        /// การรับประกันสินค้า [true = รับประกัน , false = ไม่รับประกัน]
        /// </summary>
        [JsonProperty("useWarranty", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseWarranty { get; set; }

        /// <summary>
        /// true = ทำรายการขายได้ , false = ทำรายการขายไม่ได้]
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visibility { get; set; }

        /// <summary>
        /// บันทึกการรับประกันสินค้า
        /// </summary>
        [JsonProperty("warrantyNote", NullValueHandling = NullValueHandling.Ignore)]
        public string WarrantyNote { get; set; }
    }

    public partial class ProductPrice
    {
        /// <summary>
        /// ชื่อระดับราคา
        /// </summary>
        [JsonProperty("priceTierName", NullValueHandling = NullValueHandling.Ignore)]
        public string PriceTierName { get; set; }

        /// <summary>
        /// ราคาปกติ
        /// </summary>
        [JsonProperty("regularPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? RegularPrice { get; set; }

        /// <summary>
        /// ราคาลด
        /// </summary>
        [JsonProperty("salePrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? SalePrice { get; set; }

        /// <summary>
        /// ใช้ภาษีมูลค่าเพิ่ม ที่เป็นค่าเริ่มต้น [False = ไม่ใช้ Vat default , True = ใช้ Vat
        /// default] ค่า Vat จะเป็นตาม Set Defult Vat
        /// </summary>
        [JsonProperty("useDefaultVat", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseDefaultVat { get; set; }

        /// <summary>
        /// ภาษีมูลค่าเพิ่ม [ถ้าไม่มีอยู๋ในระบบ จะทำการสร้างให้]
        /// </summary>
        [JsonProperty("vatValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? VatValue { get; set; }
    }

    public partial class ProductVariant
    {
        /// <summary>
        /// สถานะสินค้า [true = ใช้งาน , false = ไม่ใช้งาน]
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("attribute", NullValueHandling = NullValueHandling.Ignore)]
        public Attribute[] Attribute { get; set; }

        /// <summary>
        /// ต้นทุนสินค้า [ระบบ Required เมื่อเป็น Multi SKU]
        /// </summary>
        [JsonProperty("cost", NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; }

        /// <summary>
        /// แจ้งเตือนเมื่อสต็อกคงเหลือ
        /// </summary>
        [JsonProperty("lowStockAlert")]
        public int LowStockAlert { get; set; }

        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public ProductPrice[] Prices { get; set; }

        /// <summary>
        /// รหัสบาร์โค้ด
        /// </summary>
        [JsonProperty("productBarcode")]
        public string ProductBarcode { get; set; }

        /// <summary>
        /// รหัสสินค้า [ระบบ Required เมื่อเป็น สินค้า Multi SKU หรือไม่มี Product Code ด้านบน]
        /// </summary>
        [JsonProperty("productCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductCode { get; set; }

        /// <summary>
        /// รายละเอียดสินค้า
        /// </summary>
        [JsonProperty("productDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductDescription { get; set; }

        /// <summary>
        /// รูปสินค้า ให้ส่งเป็น PublicUrl
        /// </summary>
        [JsonProperty("productImage", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ProductImage { get; set; }

        /// <summary>
        /// ชื่อสินค้า
        /// </summary>
        [JsonProperty("productName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// จำนวนสินค้า
        /// </summary>
        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public long? Qty { get; set; }
    }

    public partial class Attribute
    {
        /// <summary>
        /// หมวดหมู่คุณสมบัติ เช่น สี [ถ้าไม่ตรงกับในระบบ จะแสดง Error]
        /// </summary>
        [JsonProperty("attributeName", NullValueHandling = NullValueHandling.Ignore)]
        public string AttributeName { get; set; }

        /// <summary>
        /// คุณสมบัติ เช่น แดง [ถ้าไม่ตรงกับในระบบ จะแสดง Error]
        /// </summary>
        [JsonProperty("attributeValueName", NullValueHandling = NullValueHandling.Ignore)]
        public string AttributeValueName { get; set; }
    }
    public partial class ProductsRequest
    {
        /// <summary>
        /// สถานะสินค้า
        /// </summary>
        [JsonProperty("status")]
        public int[] Status { get; set; }

        /// <summary>
        /// จำนวนรายการสินค้าที่อยากแสดง
        /// </summary>
        [JsonProperty("take")]
        public long Take { get; set; }
    }


}

