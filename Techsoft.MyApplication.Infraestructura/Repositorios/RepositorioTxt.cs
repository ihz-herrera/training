using MyApplication.Contratos;
using MyApplication.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Repositorios
{
    public class RepositorioTxt<T> : IRepositorio<T> where T : Entity
    {
        public T Consultar(T entidad)
        {
            throw new NotImplementedException();
        }

        public Cliente ConsultarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> ConsultarTodos() 
        {
            throw new NotImplementedException();
        }

        public void Guardar(T entity)
        {
            var type = entity.GetType();

            using (StreamWriter? db = new(@$"C:\Users\ivanh\Documents\DataBase\{type}.txt", true))
            {
                db.WriteLine(entity.ToString());
            }
        }

        Task<Cliente> IRepositorio<T>.ConsultarPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
