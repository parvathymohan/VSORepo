using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject_DataAccess.Models
{
  public class FleetHeaderModel
    {
        public int HeaderId { get; set; }

        public string FileName { get; set; }

        public int AgencyId { get; set; }

        public DateTime? FileDate { get; set; }

        public DateTime? DateTimeStamp { get; set; }

        public string User { get; set; }

        public int SuccessCount { get; set; }

        public int FailCount { get; set; }

        public List<FleetDetailModel> FleetDetails { get; set; }
    }
}
