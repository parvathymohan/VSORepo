//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleProject_DataAccess.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Error_Acknowledgement_Details
    {
        public Error_Acknowledgement_Details()
        {
            this.Vehicle_Upload_File_Details = new HashSet<Vehicle_Upload_File_Details>();
        }
    
        public int Detail_Id { get; set; }
        public int Header_Id { get; set; }
        public string License_Plate_Number { get; set; }
        public string License_Plate_State { get; set; }
        public string Error_Message { get; set; }
        public Nullable<int> Error_Code { get; set; }
        public System.DateTime Date_Time_Stamp { get; set; }
        public string User { get; set; }
    
        public virtual Error_Acknowledgement_Header Error_Acknowledgement_Header { get; set; }
        public virtual ICollection<Vehicle_Upload_File_Details> Vehicle_Upload_File_Details { get; set; }
    }
}
