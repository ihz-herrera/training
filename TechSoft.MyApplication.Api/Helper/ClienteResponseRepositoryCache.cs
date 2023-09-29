using System.Runtime.Caching;
using MyApplication.Contexto;
using MyApplication.Entidades;
using MyApplication.Repositorios;

namespace TechSoft.MyApplication.Api.Helper
{
    public class ClienteResponseRepositoryCache : RepositorioWrapper
    {
        private readonly MemoryCache _cache = MemoryCache.Default;

        public ClienteResponseRepositoryCache(Context context, NotificacionesService service) 
            : base(context,service)
        {
        }

        public override async Task<Cliente> ConsultarPorId(Guid id)
        {
            //Consultar en cache
            var cliente = _cache.Get(id.ToString()) as Cliente;

            //Si existe en cache retornar cliente
            if (cliente != null) return cliente;

            //Si no existe en cache consultar en base de datos
            cliente = await base.ConsultarPorId(id);

            //Si existe en base de datos agregar a cache
            if (cliente != null) _cache.Add(id.ToString(), cliente, 
                new DateTimeOffset(DateTime.UtcNow.AddSeconds(60)));
            
            return cliente;
        }


    }
}
