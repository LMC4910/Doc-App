//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FOS.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int ID { get; set; }
        public string PatientName { get; set; }
        public string MobileNo { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public Nullable<System.DateTime> AppointmentDate { get; set; }
        public Nullable<int> DayID { get; set; }
        public Nullable<int> SlotID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string Email { get; set; }
        public string Slot { get; set; }
    }
}
