using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionCompleted
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public int Nome { get; set; }
        public int Email { get; set; }
        public int Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
    }

    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
    }

    public class ClienteRepository : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            //Adiciona um cliente
        }
    }

    public interface IClienteServices
    {
        void AdicionarCliente(Cliente cliente);
    }

    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteServices(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _clienteRepository.AdicionarCliente(cliente);
        }
    }

}
