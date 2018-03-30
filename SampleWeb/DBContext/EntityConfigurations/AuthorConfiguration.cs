using SampleWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SampleWeb.DBContext.EntityConfigurations
{
    public class AuthorConfiguration : EntityTypeConfiguration<Author>
    {
        public AuthorConfiguration()
        {
            HasKey(x => x.ID);
            Property(x => x.Name).IsRequired();
        }
    }
}