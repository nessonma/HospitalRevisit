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
    
    public partial class tbVoice_Plan
    {
        public tbVoice_Plan()
        {
            this.tbVoice_Key = new HashSet<tbVoice_Key>();
        }
    
        public int Voice_Plan_ID { get; set; }
        public Nullable<int> Patient_ID { get; set; }
        public Nullable<int> Diagnosis_ID { get; set; }
        public Nullable<int> Caller_Title_ID { get; set; }
        public Nullable<System.DateTime> Planning_Time { get; set; }
        public Nullable<System.DateTime> Revisit_Days { get; set; }
        public Nullable<bool> Is_Revisit { get; set; }
        public string File_Paths { get; set; }
        public Nullable<bool> Is_Answer { get; set; }
        public Nullable<bool> Is_Manual_Revisit { get; set; }
    
        public virtual tbCaller_Title tbCaller_Title { get; set; }
        public virtual tbDiagnosis tbDiagnosis { get; set; }
        public virtual tbPatient tbPatient { get; set; }
        public virtual ICollection<tbVoice_Key> tbVoice_Key { get; set; }
        public virtual tbVoice_Plan tbVoice_Plan1 { get; set; }
        public virtual tbVoice_Plan tbVoice_Plan2 { get; set; }
    }
}
