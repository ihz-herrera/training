using MyApplication.Contexto;
using MyApplication.Contratos;
using MyApplication.Entidades;
using MyApplication.Repositorios;

namespace TechSoft.MyApplication.Api.Helper
{
    public class RepositorioWrapper : RepositorioSQLServer<Cliente>, IRepositorio<Cliente>
    {

        private readonly NotificacionesService _service;
        public RepositorioWrapper(Context context, NotificacionesService service) : base(context)
        {
            _service = service;
        }


        public override void Guardar(Cliente entidad)
        {

            base.Guardar(entidad);
            _service.Notificacion();
        }
    }
}
