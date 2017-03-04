using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;
using Data.UserAccount;

namespace DAL.Configs
{
    public class UserProfileConfig : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileConfig()
        {
            HasKey(t => t.UserId);
            // Properties
            Property(c => c.UserName).HasMaxLength(50).IsRequired();
        }
    }
}
