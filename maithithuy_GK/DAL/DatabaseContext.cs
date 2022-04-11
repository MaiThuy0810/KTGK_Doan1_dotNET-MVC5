using maithithuy_GK.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace maithithuy_GK.DAL
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() : base("name=contextconnection")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}