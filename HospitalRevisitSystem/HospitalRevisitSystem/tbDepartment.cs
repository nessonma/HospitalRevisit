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
    
    public partial class tbDepartment
    {
        public tbDepartment()
        {
            this.tbCirculation = new HashSet<tbCirculation>();
            this.tbPoint_Out = new HashSet<tbPoint_Out>();
            this.tbStaff = new HashSet<tbStaff>();
        }
    
        public int Department_ID { get; set; }
        public string Department_Name { get; set; }
    
        public virtual ICollection<tbCirculation> tbCirculation { get; set; }
        public virtual ICollection<tbPoint_Out> tbPoint_Out { get; set; }
        public virtual ICollection<tbStaff> tbStaff { get; set; }
    }
}
