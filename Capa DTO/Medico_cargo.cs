using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO
{
    public class Medico_cargo
    {
        private int id;
        private string rut;
        private string clave;
        private string nombre;
        private string apellido;
        private string especialidad;

        public int Id { get => id; set => id = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
    }
}
