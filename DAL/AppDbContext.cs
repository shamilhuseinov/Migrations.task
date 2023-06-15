using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Models;

namespace PurpleBuzz.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<AboutIntroComponent> AboutIntroComponents { get; set; }
        public DbSet<WhyYouChoose> WhyYouChooses { get; set; }
        public DbSet<Our> Ours { get; set; }
        public DbSet<WorkCategory> WorkCategories { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<ContactSuccessCompaign> ContactSuccessCompaigns { get; set; }
        public DbSet<ContactContacts> ContactContacts { get; set; }
        public DbSet<TransformComponent> TransformComponents { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
