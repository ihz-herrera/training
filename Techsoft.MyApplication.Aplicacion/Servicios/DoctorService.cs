using MyApplication.Contratos;
using MyApplication.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsoft.MyApplication.Aplicacion.Servicios
{
    public class DoctorService
    {
        private readonly IRepositorio<Doctor> _repo;

        public DoctorService(IRepositorio<Doctor> repo)
        {
            _repo = repo;
        }



        public void Guardar(string nombre, string apellido, string telefono, string cedula, int edad)
        {
            var doctor = new Doctor(nombre, apellido, telefono, cedula, edad);

            //Aseguramos que el doctor no se repita
            DoctorNotExists(doctor);

            _repo.Guardar(doctor);
        }

        private void DoctorNotExists(Doctor doctor)
        {
            //throw new NotImplementedException();
        }

        //Consultar Todos
        public async Task<List<Doctor>> ConsultarTodos()
        {
            return await _repo.ConsultarTodos();
        }
    }
}
