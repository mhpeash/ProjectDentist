using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DentistAppoinmentWebApp.Models;

namespace DentistAppoinmentWebApp.Context
{
    public class DentistContext:DbContext
    {
        public DbSet<Users> Userses { get; set; }
    }
}