using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionCompleted.Cases
{

    public interface IService{

        string Retorno();

    }


    public class ServiceA : IService
    {
        public string Retorno()
        {
            return "A";
        }
    }

    public class ServiceB : IService
    {
        public string Retorno()
        {
            return "B";
        }
    }


    public class ServiceC : IService
    {
        public string Retorno()
        {
            return "C";
        }
    }



}
