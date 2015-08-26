using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SampleProject_DataAccess.Models;
namespace SampleProject_DataAccess.Repository
{
   public class FleetContext : DbContext
    {
        public DbSet<FleetHeaderModel> FleetHeaders { get; set; }
    }
}
