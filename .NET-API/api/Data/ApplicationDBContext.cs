using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

//Class constructed to allow us to search the data tables
namespace api.Data
{
    public class ApplicationDBContext : DbContext //Inherit from DB context
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) //create a base that allows us to pass the data into DbContext
        {
            
        }
        //stores the stock and the comments and allows us to extract the data from the dataset (manipulating the entire table)
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}