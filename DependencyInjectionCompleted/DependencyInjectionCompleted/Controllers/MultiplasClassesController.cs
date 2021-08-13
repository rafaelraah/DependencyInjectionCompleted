using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionCompleted.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionCompleted.Controllers
{
    public class MultiplasClassesController : Controller
    {
        private readonly Func<string, IService> _serviceAccessor;

        public MultiplasClassesController(Func<string, IService> serviceAccessor)
        {
            _serviceAccessor = serviceAccessor;
        }

        public string Index()
        {
            return _serviceAccessor("A").Retorno();
        }
    }
}