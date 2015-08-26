using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
//using ContosoUniversity.Models;
using System.Linq.Expressions;
using SampleProject_DataAccess.Repository;

namespace SampleProject_DataAccess.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal FleetContext context { get; set; }

        internal IList<TEntity> dbSet { get; set; }
        public GenericRepository(FleetContext context)
        {
            this.context = context;
           
        }


         public virtual TEntity GetByID(object id)
        {
            return null;
        }


       

    }
}
