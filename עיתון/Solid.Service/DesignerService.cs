using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;

namespace Solid.Service
{
    public class DesignerService: IDesignersService
    {
        private readonly IDesignersRepository _designersRepository;
        public DesignerService(IDesignersRepository designersRepository)
        {
            _designersRepository = designersRepository;
        }
        public IEnumerable<Designer> GetAllDesigners()
        {
            return _designersRepository.Get();
        }
        public Designer GetById(int id)
        {
            return _designersRepository.Get(id);
        }
        public void PostDesigner(Designer value)
        {
            _designersRepository.Post(value);
        }
        public Designer PutDesigner(int id, Designer value)
        {
            return  _designersRepository.Put(id, value);
        }
        public Designer DeleteDesigner(int id)
        {

            return _designersRepository.Delete(id);
        
        }
    }
}
