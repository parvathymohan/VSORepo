using SampleProject_DataAccess.DataModel;
using SampleProject_DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleProject_DataAccess;
using HTA.DataAccess.Utilities;
using System.Data.Entity;

namespace SampleProject_DataAccess.Repository
{
   public class FleetRepository : GenericRepository<FleetHeaderModel>
    {
          public FleetRepository(FleetContext context)
            : base(context)
        {
            this.dbSet = GetAllFleetFiles();
        }

          public override FleetHeaderModel GetByID(object id)
          {
              int fileId = (int) id;             

             return this.dbSet.FirstOrDefault(i => i.HeaderId ==fileId);
          }
         


          public IList<FleetHeaderModel> GetAllFleetFiles()
          {

              using (HTATollDataEntities db = new HTATollDataEntities())
              {

                  var result =  (from FleetHeader in db.Daily_Fleet_File_Header

                                                    select new FleetHeaderModel
                                                    {
                                                        HeaderId = FleetHeader.Header_Id,
                                                        FileName = FleetHeader.FileName,
                                                        FileDate = FleetHeader.FileDate,
                                                        AgencyId = (int)FleetHeader.AgencyId,
                                                        DateTimeStamp = FleetHeader.DateTimeStamp,
                                                        User = FleetHeader.User
                                                    }
                                                   ).ToList(); ;

                  return result;
              }

          }
    }
}
