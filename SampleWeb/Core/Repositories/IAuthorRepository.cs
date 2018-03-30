using SampleWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWeb.Core.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}