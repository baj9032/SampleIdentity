using SampleWeb.Core;
using SampleWeb.Core.Repositories;
using SampleWeb.DBContext.Repositories;
using SampleWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWeb.DBContext
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Authors = new AuthorRepository(_context);
        }

        public IAuthorRepository Authors { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}