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
    
    public partial class tbStaff
    {
        public tbStaff()
        {
            this.tbPoint_Out = new HashSet<tbPoint_Out>();
        }
    
        public int Staff_ID { get; set; }
        public string Staff_Name { get; set; }
        public string Staff_No { get; set; }
        public Nullable<int> StaffDuty_ID { get; set; }
        public Nullable<int> Department_ID { get; set; }
        public string Phone_Number { get; set; }
    
        public virtual tbDepartment tbDepartment { get; set; }
        public virtual ICollection<tbPoint_Out> tbPoint_Out { get; set; }
        public virtual tbStaffDuty tbStaffDuty { get; set; }
    }
}