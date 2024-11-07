using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web_Ban_QA.Data
{
    public class Web_Ban_QAContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Web_Ban_QAContext() : base("name=Web_Ban_QAContext")
        {
        }

        public System.Data.Entity.DbSet<Web_Ban_QA.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<Web_Ban_QA.Models.Category> Categories { get; set; }
    }
}
