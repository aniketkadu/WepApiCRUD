using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace webapicrud.Models
{
    public class RestContext:DbContext
    {

        public RestContext():base("myConnectionString")
        {

        }


        public DbSet<rest> rests{ get; set;}

    }
}