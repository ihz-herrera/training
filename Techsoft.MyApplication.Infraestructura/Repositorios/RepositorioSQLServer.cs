using Microsoft.EntityFrameworkCore;
using MyApplication.Contexto;
using MyApplication.Contratos;
using MyApplication.Entidades;

namespace MyApplication.Repositorios
{
    public class RepositorioSQLServer <T> : IRepositorio<T> where T : Entity
    {

        private readonly Context _context;

        public RepositorioSQLServer(Context context)
        {
            //var optionsBuilder = new DbContextOptionsBuilder();
            //var options = optionsBuilder
            //    .UseSqlServer(@"server=.;Initial Catalog=MyApplication;Integrated Security=True; Encrypt=false")
            //    .Options
            //   ;

            //_context = new Context(options);

            _context = context;
        }

        public T Consultar(T entidad)  => _context.Set<T>().FirstOrDefault();

        public List<T> ConsultarTodos()  => _context.Set<T>().ToList();
        
        public void Guardar(T entity) 
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }


    }
}
