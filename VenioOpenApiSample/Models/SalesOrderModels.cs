using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VenioOpenApiSample.Models
{

    /// <summary>
    /// Request
    /// </summary>
    public partial class CreateUpdateSalesOrderRequest
    {
        /// <summary>
        /// รหัสผู้ติดต่อ
        /// </summary>
        [JsonProperty("contactId")]
        public long? ContactId { get; set; }

        /// <summary>
        /// สกุลเงิน เช่น "THB" , "USD" [ถ้าไม่ส่ง หรือ null ระบบจะหยิบ System Currency ของ Company
        /// นั้นๆให้]
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// รหัสลูกค้า Required [ตอน Update SalesOrder ไม่สามารถเปลี่ยน Customer ได้]
        /// </summary>
        [JsonProperty("customerCode")]
        public string CustomerCode { get; set; }

        /// <summary>
        /// ชื่อส่วนลดสินค้า
        /// </summary>
        [JsonProperty("discountName")]
        public string DiscountName { get; set; }

        /// <summary>
        /// ประเภทส่วนลด [true = percentage false = amount]  (*ระบบจะ required เมื่อมีการใส่
        /// discountValue)
        /// </summary>
        [JsonProperty("discountType")]
        public bool? DiscountType { get; set; }

        /// <summary>
        /// ส่วนลดสินค้า (*ตัว Discount ต้องมีค่าไม่เกิน ราคาของสินค้าทั้งหมด)
        /// </summary>
        [JsonProperty("discountValue")]
        public double? DiscountValue { get; set; }

        /// <summary>
        /// หัวเอกสารใน PDF [ถ้าไม่ส่งค่ามาให้เท่ากับ header default company]
        /// </summary>
        [JsonProperty("headerTemplateId")]
        public long? HeaderTemplateId { get; set; }

        /// <summary>
        /// เงื่อนไขการชำระเงิน
        /// </summary>
        [JsonProperty("paymentTerm")]
        public string PaymentTerm { get; set; }

        /// <summary>
        /// ที่อยู่จัดส่งสินค้า
        /// </summary>
        [JsonProperty("recipientAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// ชื่อผู้รับสินค้า
        /// </summary>
        [JsonProperty("recipientName")]
        public string RecipientName { get; set; }

        /// <summary>
        /// เลขที่อ้างอิง
        /// </summary>
        [JsonProperty("referenceNo")]
        public string ReferenceNo { get; set; }

        /// <summary>
        /// หมายเหตุใบสั่งขาย
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// วันที่สั่งขาย Required โดยมี Format : "YYYY-MM-DD"
        /// </summary>
        [JsonProperty("salesOrderDate")]
        public string SalesOrderDate { get; set; }

        [JsonProperty("salesOrderDetails")]
        public SalesOrderDetail[] SalesOrderDetails { get; set; }

        /// <summary>
        /// เลขใบสั่งขาย (*ถ้าไม่มีการใส่เลขมาเท่ากับการสร้าง)
        /// </summary>
        [JsonProperty("salesOrderNo")]
        public string SalesOrderNo { get; set; }

        /// <summary>
        /// บันทึกใบสั่งขายเพิ่มเติม
        /// </summary>
        [JsonProperty("salesOrderNote")]
        public string SalesOrderNote { get; set; }

        /// <summary>
        /// สถานะใบสั่งขาย [1 = draft 2 = open 3 = completed 4 = rejected 5 = cancelled]
        /// </summary>
        [JsonProperty("salesOrderStatus")]
        public long SalesOrderStatus { get; set; }

        /// <summary>
        /// หัวเรื่องใบสั่งขาย Required
        /// </summary>
        [JsonProperty("salesOrderSubject")]
        public string SalesOrderSubject { get; set; }

        /// <summary>
        /// รหัสพนักงานขาย
        /// </summary>
        [JsonProperty("staffCode")]
        public string StaffCode { get; set; }

        /// <summary>
        /// การคำนวณภาษีมูลค่าเพิ่ม Required [true = ไม่รวมภาษีมูลค่าเพิ่ม false = รวมภาษีมูลค่าเพิ่ม]
        /// </summary>
        [JsonProperty("vatCalculation")]
        public bool VatCalculation { get; set; }
    }

    public partial class SalesOrderDetail
    {
        /// <summary>
        /// ประเภทส่วนลด true = percentage false = amount (*ระบบจะ required เมื่อมีการใส่
        /// discountValue)
        /// </summary>
        [JsonProperty("discountType")]
        public bool? DiscountType { get; set; }

        /// <summary>
        /// ส่วนลดสินค้า (*ตัว Discount ต้องมีค่าไม่เกิน ราคาของสินค้านั้น)
        /// </summary>
        [JsonProperty("discountValue")]
        public double? DiscountValue { get; set; }

        /// <summary>
        /// ราคาสินค้าที่ต้องการกำหนด [null = ราคาสินค้าตามในระบบ]
        /// </summary>
        [JsonProperty("price")]
        public double? Price { get; set; }

        /// <summary>
        /// รหัสสินค้า Required
        /// </summary>
        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        /// <summary>
        /// รายละเอียดสินค้า [null = ราคาละเอียดสินค้าตามในระบบ]
        /// </summary>
        [JsonProperty("productDescription")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// ชื่อสินค้าที่ต้องการกำหนด [null = ชื่อสินค้าตามในระบบ]
        /// </summary>
        [JsonProperty("productName")]
        public string ProductName { get; set; }

        /// <summary>
        /// หน่วยสินค้า [null = หน่วยสินค้าตามในระบบ] (*ถ้าใส่ค่า Unit ไม่ตรงกับระบบ ให้ error)
        /// </summary>
        [JsonProperty("productUnitName")]
        public string ProductUnitName { get; set; }

        /// <summary>
        /// จำนวนสินค้า (*กรอกจำนวนได้ไม่เกินสินค้าที่มีใน stock จนกว่าจะมีการเปิด Permission บน Web)
        /// </summary>
        [JsonProperty("qty")]
        public long? Qty { get; set; }

        /// <summary>
        /// ภาษีมูลค่าเพิ่ม(%) (*ถ้าไม่มีอยู่ในระบบ ให้สร้างใหม่ กรณี inactive ระบบ จะแสดง error)
        /// [ถ้าส่ง Null มา ระบบจะ Set เป็น No Vat]
        /// </summary>
        [JsonProperty("vatTaxValue")]
        public double? VatTaxValue { get; set; }

        /// <summary>
        /// ภาษีหัก ณ ที่จ่าย(%) (*ถ้าไม่มีอยู่ในระบบ จะแสดง error) [ถ้าส่ง Null มา ระบบจะ Set เป็น
        /// none]
        /// </summary>
        [JsonProperty("whtTaxValue")]
        public double? WhtTaxValue { get; set; }
    }

}

