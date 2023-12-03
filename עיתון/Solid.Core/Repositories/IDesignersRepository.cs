using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;

namespace Solid.Core.Repositories
{
    public interface IDesignersRepository
    {
        public IEnumerable<Designer> Get();
        public Designer Get(int id);
        public void Post( Designer value);
        public Designer Put(int id, Designer value);
        public Designer Delete(int id);
        
    }
}
