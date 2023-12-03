
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
    public class EditorsRepository : IEditorsRepository
    {
        private readonly DataContext _context;

        public EditorsRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Editor> Get()
        {
            return _context._Editors;
        }

        public Editor Get(int id)
        {
            Editor editor = new Editor();
            editor = _context._Editors.Find(i => i.Id == id);
            if (editor != null)
            {
                return editor;
            }
            return null;
        }
        public void Post(Editor value)
        {
            _context._Editors.Add(value);
        }

        public Editor Put(int id, Editor value)
        {
            Editor editor;
            editor = _context._Editors.Find(i => i.Id == id);
            if (editor != null)
            {
                editor.Name = value.Name;
                editor.Pon = value.Pon;
                editor.Adress = value.Adress;
                editor.TEditor = value.TEditor;
                editor.Vetek = value.Vetek;
                return editor;
            }
            return null;
        }
        public Editor Delete(int id)
        {
            Editor editor;
            editor = _context._Editors.Find(i => i.Id == id);
            if (editor != null)
            {
                _context._Editors.Remove(editor);
                return editor;

            }
            return  null;
        }
    }

}

