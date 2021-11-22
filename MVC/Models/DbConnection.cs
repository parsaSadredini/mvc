using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class DbConnection :DbContext
    {
        public DbConnection():base("name=")
        {
            
        }
    }
}