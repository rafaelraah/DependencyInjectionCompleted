using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionCompleted.Controllers
{
    public class VidaRealController : Controller
    {
        private readonly IClienteServices _clienteServices;

        public VidaRealController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        public void Index()
        {
            _clienteServices.AdicionarCliente(new Cliente());
        }
    }
}