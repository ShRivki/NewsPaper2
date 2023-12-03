using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Repositories;

namespace Solid.Data.Repositories
{
    public class DesignersRepository: IDesignersRepository
    {
        private readonly DataContext _context;
        public DesignersRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Designer> Get()
        {
            return _context._Designers;
        }
        public Designer Get(int id)
        {
            Designer designer = new Designer();
            designer = _context._Designers.Find(i => i.Id == id);
            if (designer != null)
            {
                return designer;
            }
            return null;
        }
        public void Post(Designer value)
        {
            _context._Designers.Add(value);
        }
        public Designer Put(int id,Designer value)
        {
            Designer designer;
            designer = _context._Designers.Find(i => i.Id == id);
            if (designer != null)
            {
                designer.Name = value.Name;
                designer.Pon = value.Pon;
                designer.Adress = value.Adress;
                designer.IsDesigningAi = value.IsDesigningAi;
                designer.Vetek = value.Vetek;
                return designer;

            }
            return null;

        }
        public Designer Delete(int id)
        {
            Designer designer;
            designer = _context._Designers.Find(i => i.Id == id);
            if (designer != null)
            {
                _context._Designers.Remove(designer);
                return designer;

            }
            return null;
        }
    }
}
