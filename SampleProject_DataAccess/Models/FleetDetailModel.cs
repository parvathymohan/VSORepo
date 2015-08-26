using HTA.DataAccess.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject_DataAccess.Models
{
   public class FleetDetailModel
    {
        public int DetailId { get; set; }

        public int HeaderId { get; set; }

        public string Brand { get; set; }

        public string VehicleIdNumber { get; set; }

        public string LicensePlateNumber { get; set; }

        public string LicensePlateState { get; set; }

        public int? ManufactureYear { get; set; }

        public string VehicleMake { get; set; }

        public string VehicleModel { get; set; }

        public string VehicleColor { get; set; }

        public string VIN { get; set; }

        public string LocationGroup { get; set; }

        public string LocationCode { get; set; }

        public string LocationName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string Address3 { get; set; }

        public DateTime DateTimeStamp { get; set; }

        public string User { get; set; }

        public Constants.ErrorStatus Status { get; set; }

        public string ErrorString { get; set; }

        public string ErrorNote { get; set; }

        public int? errornoteId { get; set; }

      

    }
}
