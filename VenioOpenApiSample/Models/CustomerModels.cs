using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenioOpenApiSample.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Request
    /// </summary>
    public partial class CreateUpdateCustomerRequest
    {
        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        /// <summary>
        /// รหัสสาขา
        /// </summary>
        [JsonProperty("branchCode")]
        public string BranchCode { get; set; }

        /// <summary>
        /// คลาสลูกค้า โดยใส่ค่าได้ มากที่สุด 3 ตัวอักษร
        /// </summary>
        [JsonProperty("classificationName")]
        public string ClassificationName { get; set; }

        [JsonProperty("contacts")]
        public Contacts Contacts { get; set; }

        /// <summary>
        /// ชื่อรองลูกค้า เช่น ชื่อลูกค้าภาษาอื่นๆ
        /// </summary>
        [JsonProperty("customer2ndName")]
        public string Customer2NdName { get; set; }

        /// <summary>
        /// รายการนามแฝง
        /// </summary>
        [JsonProperty("customerAliases")]
        public string[] CustomerAliases { get; set; }

        /// <summary>
        /// วันเกิดลูกค้า โดยมี Format : YYYY-MM-DD
        /// </summary>
        [JsonProperty("customerBirthdate")]
        public string CustomerBirthdate { get; set; }

        /// <summary>
        /// รหัสลูกค้า [ถ้าไม่ใส่จะเป็น การสร้างลูกค้าใหม่]
        /// </summary>
        [JsonProperty("customerCode")]
        public string CustomerCode { get; set; }

        /// <summary>
        /// อีเมลลูกค้า
        /// </summary>
        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// เพศลูกค้า [1 = Male , 2 = Female]
        /// </summary>
        [JsonProperty("customerGender")]
        public string CustomerGender { get; set; }

        /// <summary>
        /// กลุ่มลูกค้า [*ทำการสร้างให้ใหม่เมื่อข้อมูลไม่ตรงกัน]
        /// </summary>
        [JsonProperty("customerGroupName")]
        public string CustomerGroupName { get; set; }

        [JsonProperty("customerIncome")]
        public string CustomerIncome { get; set; }

        /// <summary>
        /// สถานภาพสมรส [1 = Single , 2 = Engaged , 3 = Married , 4 = Separated , 5 = Disvorced , 6 =
        /// Widowed]
        /// </summary>
        [JsonProperty("customerMaritalStatus")]
        public string CustomerMaritalStatus { get; set; }

        /// <summary>
        /// เบอร์มือถือลูกค้า
        /// </summary>
        [JsonProperty("customerMobile")]
        public string CustomerMobile { get; set; }

        /// <summary>
        /// ชื่อลูกค้า Required [ชื่อลูกค้าห้ามซ้ำกัน]
        /// </summary>
        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        /// <summary>
        /// เมื่อ CustomerStatus เป็น Ended , Closed
        /// </summary>
        [JsonProperty("customerNote")]
        public string CustomerNote { get; set; }

        /// <summary>
        /// เบอร์โทรศัพท์ลูกค้า
        /// </summary>
        [JsonProperty("customerPhone")]
        public string CustomerPhone { get; set; }

        /// <summary>
        /// รูปของลูกค้า โดยรับเป็น URL
        /// </summary>
        [JsonProperty("customerPicture")]
        public string CustomerPicture { get; set; }

        /// <summary>
        /// ตำแหน่งลูกค้า
        /// </summary>
        [JsonProperty("customerPosition")]
        public string CustomerPosition { get; set; }

        /// <summary>
        /// Social Account ของลูกค้า
        /// </summary>
        [JsonProperty("customerSocialAccount")]
        public CustomerSocialAccount CustomerSocialAccount { get; set; }

        /// <summary>
        /// สถานะของลูกค้า Required : 1 = Lead , 2 = Prospect , 3 = Customer
        /// </summary>
        [JsonProperty("customerState")]
        public string CustomerState { get; set; }

        /// <summary>
        /// สถานะการใช้งาน 0 = active , 1 = ended (Required Note) , 2 = closed (Required Note)
        /// </summary>
        [JsonProperty("customerStatus")]
        public string CustomerStatus { get; set; }

        [JsonProperty("customerTags")]
        public string[] CustomerTags { get; set; }

        /// <summary>
        /// เลขประจำตัวผู้เสียภาษี
        /// </summary>
        [JsonProperty("customerTaxNo")]
        public string CustomerTaxNo { get; set; }

        /// <summary>
        /// ประเภท 1 = Business , 2 = individual
        /// </summary>
        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }

        /// <summary>
        /// ความสนใจ [*ทำการสร้างให้ใหม่เมื่อข้อมูลไม่ตรงกัน]
        /// </summary>
        [JsonProperty("interestsName")]
        public string[] InterestsName { get; set; }

        /// <summary>
        /// สถานะลูกค้า 1 = New , 2 = Followup , 3 = Unqualified , 4 = Interested
        /// [*ถ้าไม่มีการส่งข้อมูลมา Lead = 1 ,Prospect =  4 , Customer = 4]
        /// </summary>
        [JsonProperty("leadStatus")]
        public string LeadStatus { get; set; }

        /// <summary>
        /// รหัสพนังงาน
        /// </summary>
        [JsonProperty("owners")]
        public string[] Owners { get; set; }

        /// <summary>
        /// แหล่งที่มาลูกค้า
        /// </summary>
        [JsonProperty("sourceName")]
        public string SourceName { get; set; }

        /// <summary>
        /// หัวข้อเหตุผลที่พลาด [*ระบบจะ Required เมื่อ leadStatus = 3 & customerState = 1
        /// [Unqualified] เท่านั้น]
        /// </summary>
        [JsonProperty("unqulifiedReasonName")]
        public string UnqulifiedReasonName { get; set; }

        /// <summary>
        /// เหตุผล [*ระบบจะ Required เมื่อ leadStatus = 3 & customerState = 1 [Unqualified] เท่านั้น]
        /// </summary>
        [JsonProperty("unqulifiedReasonNote")]
        public string UnqulifiedReasonNote { get; set; }
    }

    public partial class Address
    {
        /// <summary>
        /// ละติจูด
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// ที่อยู่
        /// </summary>
        [JsonProperty("locationAddress")]
        public string LocationAddress { get; set; }

        /// <summary>
        /// ชื่อสถานที่
        /// </summary>
        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        /// <summary>
        /// ประเภทสถานที่ [1 = billing address , 2 = shipping address]
        /// </summary>
        [JsonProperty("locationType")]
        public string LocationType { get; set; }

        /// <summary>
        /// ลองจิจูด
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public partial class Contacts
    {
        /// <summary>
        /// วันเกิด ของผู้ติดต่อ โดยมี Format : "YYYY-MM-DD"
        /// </summary>
        [JsonProperty("contactBirthdate")]
        public string ContactBirthdate { get; set; }

        /// <summary>
        /// Email ของผู้ติดต่อ
        /// </summary>
        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// เบอร์โทรศัพมือถือ ของผู้ติดต่อ
        /// </summary>
        [JsonProperty("contactMobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// ผู้ติดต่อ
        /// </summary>
        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactNote")]
        public string ContactNote { get; set; }

        /// <summary>
        /// เบอร์โทรศัพ ของผู้ติดต่อ
        /// </summary>
        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// รูปของผู้ติดต่อ ใช้เป็น URL ของรูป
        /// </summary>
        [JsonProperty("contactPicture")]
        public string ContactPicture { get; set; }

        /// <summary>
        /// ตำแหน่ง ของผู้ติดต่อ
        /// </summary>
        [JsonProperty("contactPosition")]
        public string ContactPosition { get; set; }

        /// <summary>
        /// true = active , false = inactive
        /// </summary>
        [JsonProperty("contactStatus")]
        public string ContactStatus { get; set; }
    }

    public partial class CustomField
    {
        /// <summary>
        /// ชื่อหัวข้อฟิลด์
        /// </summary>
        [JsonProperty("customFieldName", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomFieldName { get; set; }

        /// <summary>
        /// ข้อมูลของฟิลด์
        /// </summary>
        [JsonProperty("customFieldValue", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CustomFieldValue { get; set; }
    }

    /// <summary>
    /// Social Account ของลูกค้า
    /// </summary>
    public partial class CustomerSocialAccount
    {
        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        [JsonProperty("line")]
        public string Line { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("skype")]
        public string Skype { get; set; }

        [JsonProperty("telegram")]
        public string Telegram { get; set; }

        [JsonProperty("wechat")]
        public string Wechat { get; set; }

        [JsonProperty("whatsapp")]
        public string Whatsapp { get; set; }
    }

  
}
