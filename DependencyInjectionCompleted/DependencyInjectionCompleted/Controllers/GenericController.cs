using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionCompleted.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionCompleted.Controllers
{
    public class GenericController : Controller
    {

        private readonly IGenericRepository<Cliente> _clienteRepository;

        public GenericController(IGenericRepository<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Index()
        {
            _clienteRepository.Adicionar(new Cliente());
        }
    }
}