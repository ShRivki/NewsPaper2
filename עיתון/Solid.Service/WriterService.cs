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
    public class WriterService: IWritersService
    {
        private readonly IWritersRepository _wirersRepository;

        public WriterService(IWritersRepository wirersRepository)
        {
            _wirersRepository = wirersRepository;
        }
        public IEnumerable<Writer> GetAllWriters()
        {
            return _wirersRepository.Get();
        }
        public Writer GetById(int id)
        {

            return _wirersRepository.Get(id);
        }
        public void PostWriter(Writer value)
        {
            _wirersRepository.Post(value);

        }

        public Writer PutWriter(int id, Writer value)
        {

            return _wirersRepository.Put(id, value);
        }
        public Writer DeleteWriter(int id)
        {

            return _wirersRepository.Delete(id);

        }
    }
}
