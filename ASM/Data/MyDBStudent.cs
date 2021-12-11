using ASM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASM.Data
{
    public class MyDBStudent : DbContext
    {
        public MyDBStudent() : base("name=MyDbStudent")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}