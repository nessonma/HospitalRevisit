//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalRevisitSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbPoint_Out
    {
        public int Point_Out_ID { get; set; }
        public Nullable<int> Information_Register_ID { get; set; }
        public Nullable<int> Deal_Way_ID { get; set; }
        public Nullable<int> Response_Department_ID { get; set; }
        public Nullable<int> Response_Staff_ID { get; set; }
        public Nullable<System.DateTime> Department_Response_Time { get; set; }
        public string Department_Response_Content { get; set; }
        public string Remarks { get; set; }
    
        public virtual tbDeal_Way tbDeal_Way { get; set; }
        public virtual tbDepartment tbDepartment { get; set; }
        public virtual tbInformation_Register tbInformation_Register { get; set; }
        public virtual tbStaff tbStaff { get; set; }
    }
}