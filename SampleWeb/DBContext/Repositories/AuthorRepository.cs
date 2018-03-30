using SampleWeb.Core.Entities;
using SampleWeb.Core.Repositories;
using SampleWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWeb.DBContext.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Author GetAuthorWithCourses(int id)
        {
            return ApplicationDbContext.Authors.SingleOrDefault(a => a.ID == id);
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}