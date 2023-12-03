using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;

namespace Solid.Service
{
    public class EditorService: IEditorsService
    {
        private readonly IEditorsRepository _editorsRepository;
        public EditorService(IEditorsRepository editorsRepository)
        {
            _editorsRepository= editorsRepository;
        }
        public IEnumerable<Editor> GetAllEditors()
        {
            return _editorsRepository.Get();
        }

        public Editor GetById(int id)
        {

             

            return _editorsRepository.Get(id);
        }
        public void PostEditor(Editor value)
        {
            _editorsRepository.Post(value); 
        }

        public Editor PutEditor(int id, Editor value)
        {



            return _editorsRepository.Put(id, value);
        }
        public Editor DeleteEditor(int id)
        {
            return _editorsRepository.Delete(id);
            
        }

    }
}
