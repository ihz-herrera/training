using MyApplication.Contratos;
using MyApplication.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Repositorio
{
    internal class ClientesRepository : IRepositorio<Cliente>
    {
        public Cliente Consultar(Cliente entidad)
        {
            throw new NotImplementedException();
        }

        public async Task<Cliente> ConsultarPorId(Guid id)
        {
            var clienteId = id;
            var httpCliente = new HttpClient();
            Cliente resultado;
           
                var response = await httpCliente.GetAsync(
                $"https://localhost:7224/api/clientes/ {clienteId}");

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    resultado = JsonConvert.DeserializeObject<Cliente>(responseBody) ?? throw new ArgumentNullException();

              
                }
                else
                {
                    throw new InvalidOperationException("No se encontró el cliente");
                }

                return resultado;
            }

        public List<Cliente> ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        public void Guardar(Cliente entidad)
        {
            throw new NotImplementedException();
        }
    }
}
