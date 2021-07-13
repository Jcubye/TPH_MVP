using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO
{
    public class Ingreso
    {
        private int id;
        private DateTime fecha;
        private string prioridad;
        private int paciente_id;
        private int medico_cargo_id;

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Prioridad { get => prioridad; set => prioridad = value; }
        public int Paciente_id { get => paciente_id; set => paciente_id = value; }
        public int Medico_cargo_id { get => medico_cargo_id; set => medico_cargo_id = value; }
    }
}
