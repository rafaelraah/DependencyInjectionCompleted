using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionCompleted.Cases
{
    public interface IGenericRepository<T> where T : class
    {
        void Adicionar(T obj);
    }

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Adicionar(T obj)
        {
            // Faz alguma coisa
        }
    }
}
