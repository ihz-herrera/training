using MyApplication.Contratos;
using MyApplication.Entidades;
using MyApplication.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Fabricas
{
    public static class RepositorioFabrik
    {
        public  enum DBOptions
        {
            SQLServer,
            SQLLite,
            Txt
        }

        [Obsolete("Metodo Obsoleto, usar Inyector de dependencias",true)]
        public static IRepositorio<T> CrearRepositorio<T>(DBOptions dbOptions) where T : Entity
        {
            switch (dbOptions)
            {
                //case  DBOptions.SQLServer:
                //    return new RepositorioSQLServer<T>();
                //case DBOptions.SQLLite:
                //    return new RepositorioSQLLite<T>();
                case DBOptions.Txt:
                    return new RepositorioTxt<T>();
                default:
                    return null;
            }
        }
    }
}
