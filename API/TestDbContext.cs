using CommunityPortalClassLibrary;
using Microsoft.EntityFrameworkCore;

namespace API
{
	public class TestDbContext : DbContext
	{
		public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) { }
		public DbSet<UserManagement> Users {  get; set; }
		public DbSet<Forum> Forums { get; set; }
		public DbSet<CurrentEvents> CurrentEvents { get; set; }
	}
}
