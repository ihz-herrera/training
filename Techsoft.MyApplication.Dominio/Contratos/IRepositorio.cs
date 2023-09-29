using MyApplication.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Contratos
{
    public interface IRepositorio <T> where T : Entity
    {
        void Guardar(T entidad) ;

        T Consultar(T entidad) ;

        Task<List<T>> ConsultarTodos() ;
        Task<Cliente> ConsultarPorId(Guid id);
    }
}
