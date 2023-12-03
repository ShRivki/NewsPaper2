using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;

namespace Solid.Core.Repositories
{
    public interface IEditorsRepository
    {
        public IEnumerable<Editor> Get();
        public Editor Get(int id);
        public void Post(Editor value);

        public Editor Put(int id, Editor value);
        public Editor Delete(int id);
    }
}
