using System.Data.Entity;
using Data.UserAccount;
using Data.Domain;
using DAL.Configs;

namespace DAL
{
    public class ContactListContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
       // public DbSet<Address> Addresses;
        public DbSet<UserProfile> UserProfiles { get; set; }
        public ContactListContext()
           : base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressConfig());
            modelBuilder.Configurations.Add(new ContactConfig());
            modelBuilder.Configurations.Add(new UserProfileConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
