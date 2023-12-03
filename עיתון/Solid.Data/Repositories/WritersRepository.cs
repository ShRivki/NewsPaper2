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
    public class WritersRepository: IWritersRepository
    {
        private readonly DataContext _context;

        public WritersRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Writer> Get()
        {
            return _context._Writers;
        }
        public Writer Get(int id)
        {
            Writer writer;
            writer = _context._Writers.Find(i => i.Id == id);
            if (writer != null)
            {
                return writer;
            }
            return null;
        }
        public void Post( Writer value)
        {
            _context._Writers.Add(value);

        }

        public Writer Put(int id, Writer value)
        {
            Writer writer;
            writer = _context._Writers.Find(i => i.Id == id);
            if (writer != null)
            {
                writer.Adress = value.Adress;
                writer.Name = value.Name;
                writer.Pon = value.Pon;
                writer.Salary = value.Salary;
                writer.TWriter = value.TWriter;
                writer.Vetek = value.Vetek;
                return writer;
            }
            return null;
        }
        public Writer Delete(int id)
        {
            Writer writer;
            writer = _context._Writers.Find(i => i.Id == id);
            if (writer != null)
            {
                _context._Writers.Remove(writer);
                return writer;

            }
            return null;

        }
    }
}
