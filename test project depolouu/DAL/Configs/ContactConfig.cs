using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;

namespace DAL.Configs
{
    public class ContactConfig : EntityTypeConfiguration<Contact>
    {
        public ContactConfig()
        {
            // Primary Key
            HasKey(t => t.ContactId);

            // Properties
            Property(c => c.FirstName).HasMaxLength(50).IsRequired();
            Property(c => c.LastName).HasMaxLength(50);
            Property(c => c.Email).HasMaxLength(100);

        }
    }
}
