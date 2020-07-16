using inventory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace inventory
{
    public class InventroyContext : DbContext 
    {
        public DbSet<Item> Items { get; set; }
}
}