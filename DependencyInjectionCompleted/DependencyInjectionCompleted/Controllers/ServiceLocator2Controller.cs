using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionCompleted.Controllers
{
    public class ServiceLocator2Controller : Controller
    {

        public void Index([FromServices] IServiceProvider _serviceProvider)
        {
            _serviceProvider.GetRequiredService<IClienteServices>().AdicionarCliente(new Cliente());
        }
    }
}