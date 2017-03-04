using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;

namespace DAL.Configs
{
    class AddressConfig : ComplexTypeConfiguration<Address>
    {
        public AddressConfig()
        {
            Property(t => t.Street).HasColumnName("Street").HasMaxLength(50);
            Property(t => t.City).HasColumnName("City").HasMaxLength(50);
            Property(t => t.State).HasColumnName("State").HasMaxLength(2);
            Property(t => t.Zip).HasColumnName("Zip").HasMaxLength(10);
        }
    }
}
