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
    public partial class CreateUpdateQuotationRequest
    {
        /// <summary>
        /// ชื่อผู้ติดต่อ
        /// </summary>
        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        /// <summary>
        /// สกุลเงิน เช่น "THB" , "USD" [ถ้าไม่ส่ง หรือ null ระบบจะหยิบ System Currency ของ Company
        /// นั้นๆให้] optional
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// รหัสลูกค้า
        /// </summary>
        [JsonProperty("customerCode")]
        public string CustomerCode { get; set; }

        /// <summary>
        /// ชื่อส่วนลด
        /// </summary>
        [JsonProperty("discountName")]
        public string DiscountName { get; set; }

        /// <summary>
        /// ประเภทส่วนลด TRUE คือเป็น%, False คิดเป็นบาท
        /// </summary>
        [JsonProperty("discountType")]
        public bool? DiscountType { get; set; }

        /// <summary>
        /// ส่วนลด
        /// </summary>
        [JsonProperty("discountValue")]
        public double? DiscountValue { get; set; }

        /// <summary>
        /// หัวเอกสารในpdf
        /// </summary>
        [JsonProperty("headerTemplateId")]
        public long? HeaderTemplateId { get; set; }

        /// <summary>
        /// เงื่อนไขการชำระเงิน
        /// </summary>
        [JsonProperty("paymentTerm")]
        public string PaymentTerm { get; set; }

        /// <summary>
        /// วันที่สร้างใบเสนอราคา โดยมี Format : YYYY-MM-DD
        /// </summary>
        [JsonProperty("quotationDate")]
        public string QuotationDate { get; set; }

        /// <summary>
        /// รายการสินค้า
        /// </summary>
        [JsonProperty("quotationDetails")]
        public QuotationDetail[] QuotationDetails { get; set; }

        /// <summary>
        /// รายละเอียดเพิ่มเติม
        /// </summary>
        [JsonProperty("quotationNote")]
        public string QuotationNote { get; set; }

        /// <summary>
        /// สถานะใบเสนอราคา: 1 ร่าง 2 รออนุมัติ 3 รอส่ง 4 ส่งแล้ว 5 เสร็จสิ้น 6 ปฏิเสธ 7 ยกเลิก
        /// </summary>
        [JsonProperty("quotationStatus")]
        public long QuotationStatus { get; set; }

        /// <summary>
        /// ชื่อหัวข้อใบเสนอราคา
        /// </summary>
        [JsonProperty("quotationSubject")]
        public string QuotationSubject { get; set; }

        /// <summary>
        /// วันที่สิ้นสุด โดยมี Format : YYYY-MM-DD
        /// </summary>
        [JsonProperty("quotationValidUntil")]
        public string QuotationValidUntil { get; set; }

        /// <summary>
        /// ที่อยู่ผู้รับ
        /// </summary>
        [JsonProperty("recipientAddress")]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// ชื่อผู้รับ
        /// </summary>
        [JsonProperty("recipientName")]
        public string RecipientName { get; set; }

        /// <summary>
        /// เลขที่อ้างอิ้งใบเสนอราคา ต้องใส่เมื่อทำการแก้ไขข้อมูล
        /// </summary>
        [JsonProperty("referenceNo")]
        public string ReferenceNo { get; set; }

        /// <summary>
        /// หมายเหตุใบเสนอราคา
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// รหัสพนักงานขาย
        /// </summary>
        [JsonProperty("staffCode")]
        public string StaffCode { get; set; }

        /// <summary>
        /// การคำนวณภาษีมูลลค่าเพิ่ม
        /// </summary>
        [JsonProperty("vatCalculation")]
        public bool VatCalculation { get; set; }
    }

    public partial class QuotationDetail
    {
        /// <summary>
        /// ประเภทส่วนลด จะเป็น TRUEคือเป็น% ถ้าfFalseคิดเป็นบาท
        /// </summary>
        [JsonProperty("discountType")]
        public bool? DiscountType { get; set; }

        /// <summary>
        /// ส่วนลด
        /// </summary>
        [JsonProperty("discountValue")]
        public double? DiscountValue { get; set; }

        /// <summary>
        /// ราคากำหนดต่อหน่วย
        /// </summary>
        [JsonProperty("price")]
        public double? Price { get; set; }

        /// <summary>
        /// รหัสสินค้า
        /// </summary>
        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        /// <summary>
        /// รายละเอียดสินค้า
        /// </summary>
        [JsonProperty("productDescriptioin")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// ชื่อสินค้า
        /// </summary>
        [JsonProperty("productName")]
        public string ProductName { get; set; }

        /// <summary>
        /// หน่วยสินค้า
        /// </summary>
        [JsonProperty("productUnitName")]
        public string ProductUnitName { get; set; }

        /// <summary>
        /// จำนวน จำเป็นต้องใส่ ห้ามใส่เกินจำนวนที่มีในstock
        /// </summary>
        [JsonProperty("qty")]
        public double Qty { get; set; }

        /// <summary>
        /// ภาษี มูลลค่าเพิ่ม
        /// </summary>
        [JsonProperty("vatTaxValue")]
        public double? VatTaxValue { get; set; }

        /// <summary>
        /// ภาษี ณ ที่จ่าย
        /// </summary>
        [JsonProperty("whTaxValue")]
        public double? WhTaxValue { get; set; }
    }

    public partial class QuotationRequest
    {
        /// <summary>
        /// รหัสลูกค้า
        /// </summary>
        [JsonProperty("customerCode")]
        public string CustomerCode { get; set; }

        /// <summary>
        /// วันที่สร้างใบเสนอราคา โดยมี Format : YYYY-MM-DD
        /// </summary>
        [JsonProperty("quotationDate")]
        public string QuotationDate { get; set; }

        /// <summary>
        /// รหัสใบเสนอราคา
        /// </summary>
        [JsonProperty("quotationNo")]
        public string QuotationNo { get; set; }

        /// <summary>
        /// สถานะใบเสนอราคา 1 ร่าง 2 รออนุมัติ 3 รอส่ง 4 ส่งแล้ว 5 เสร็จสิ้น  6 ปฏิเสธ 7 ยกเลิก
        /// </summary>
        [JsonProperty("quotationStatus")]
        public long? QuotationStatus { get; set; }

        /// <summary>
        /// จำนวนรายการที่ต้องการข้าม
        /// </summary>
        [JsonProperty("skip")]
        public long? Skip { get; set; }

        /// <summary>
        /// รหัสพนักงานขาย
        /// </summary>
        [JsonProperty("staffCode")]
        public string StaffCode { get; set; }

        /// <summary>
        /// จำนวนรายการที่ต้องการแสดง
        /// </summary>
        [JsonProperty("take")]
        public long Take { get; set; }
    }
    public partial class QuotationConvertToSalesOrder
    {
        [JsonProperty("quotationNo")]
        public string QuotationNo { get; set; }
    }

}

