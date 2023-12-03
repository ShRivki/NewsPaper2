using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;

namespace Solid.Core.Repositories
{
    public interface IWritersRepository
    {
        public IEnumerable<Writer> Get();
        public Writer Get(int id);
        public void Post(Writer value);

        public Writer Put(int id, Writer value);
        public Writer Delete(int id);
    }
}
