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
    
    public partial class tbCirculation
    {
        public int Circulation_ID { get; set; }
        public int Processor_Serial_Number { get; set; }
        public Nullable<int> Department_ID { get; set; }
    
        public virtual tbCirculation tbCirculation1 { get; set; }
        public virtual tbCirculation tbCirculation2 { get; set; }
        public virtual tbDepartment tbDepartment { get; set; }
    }
}
