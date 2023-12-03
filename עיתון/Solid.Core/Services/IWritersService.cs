using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;

namespace Solid.Core.Services
{
    public interface IWritersService
    {
        public IEnumerable<Writer> GetAllWriters();
        public Writer GetById(int id);
        public void PostWriter(Writer value);

        public Writer PutWriter(int id, Writer value);
        public Writer DeleteWriter(int id);
    }
}
