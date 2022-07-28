using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EclerxAshutoshRanaQuestion3.Models
{
    public class ApplicationDbContext :DbContext 
    {
        public ApplicationDbContext() : base("CmpConn")
        {

        }
        public DbSet<Company> companies { get; set; }

       
       
    }
}