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
    public interface IEditorsService
    {
        public IEnumerable<Editor> GetAllEditors();
        public Editor GetById(int id);
        public void PostEditor(Editor value);
        public Editor PutEditor(int id, Editor value);
        public Editor DeleteEditor(int id);

    }
}
