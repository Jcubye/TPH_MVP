using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO
{
    public class Atencion
    {
        private int id;
        private DateTime fecha;
        private string detalle;
        private int ingreso_id;

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public int Ingreso_id { get => ingreso_id; set => ingreso_id = value; }
    }
}
