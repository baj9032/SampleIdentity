using SampleWeb.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWeb.Core.Entities
{
    public class Author: IBaseModel
    {
        public Author()
        {
        }

        public int ID
        {
            get;
            set;
        }

        public string Name { get; set; }

    }
}