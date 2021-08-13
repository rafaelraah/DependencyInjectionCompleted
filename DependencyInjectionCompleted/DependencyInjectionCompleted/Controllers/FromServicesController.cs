using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionCompleted.Controllers
{
    public class FromServicesController : Controller
    {
        /*Não é recomendado. O recomendado é por construtores, porém, pode ser necessário em certas ocasiões. 
         * Porém, dificulta testes, entre outros problemas*/
        public void Index([FromServices] IClienteServices clienteServices)
        {
            clienteServices.AdicionarCliente(new Cliente());
        }
    }
}