using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Repositories;

namespace Solid.Core.Services
{
    public interface IDesignersService
    {
        public IEnumerable<Designer> GetAllDesigners();
        public Designer GetById(int id);
        public void PostDesigner(Designer value);
        public Designer PutDesigner(int id, Designer value);
        public Designer DeleteDesigner(int id);
    }
}
