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
    
    public partial class tbVisits_Information
    {
        public int Visits_Information_ID { get; set; }
        public Nullable<int> Patient_ID { get; set; }
        public Nullable<System.DateTime> Submit_Date { get; set; }
        public string The_Reservation_Department { get; set; }
        public string ZocDoc { get; set; }
        public Nullable<System.DateTime> Records_Generated_Date { get; set; }
        public Nullable<bool> Is_Exercise { get; set; }
        public string Exercise_Staff_No { get; set; }
        public string Remarks { get; set; }
    }
}
