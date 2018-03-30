using SampleWeb.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWeb.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository Authors { get; }
        int Complete();
    }
}