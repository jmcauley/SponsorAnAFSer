using System.Data.Entity;

namespace SponsorAnAFSer.Models
{
    public class AdminContext : DbContext
    {
        public DbSet<StudentWidget> StudentWidgets { get; set; }
        public DbSet<Donation> Donations { get; set; }
    }
}