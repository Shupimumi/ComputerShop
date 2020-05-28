using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerShop.Domain
{
	public class ComputerShopContext : DbContext
	{
		public ComputerShopContext(DbContextOptions<ComputerShopContext> options) : base(options)
		{
			var customer = new Customer();
		}
		public DbSet<Customer> Customers { get; set; }
	
	}
}
