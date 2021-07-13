using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO
{
    public class Paciente
    {
        private int id;
        private string rut;
        private string nombre;
        private string apellido;
        private string antecedentes;
        private string stock_productos;
        private string disponibilidad;
        private string epicrisis;
        private string telefono;
        private int tutor_id;
        private string tutor_nombre;
        private int ubicacion_id;
        
        public int Id { get => id; set => id = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Antecedentes { get => antecedentes; set => antecedentes = value; }
        public string Stock_productos { get => stock_productos; set => stock_productos = value; }
        public string Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public string Epicrisis { get => epicrisis; set => epicrisis = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Tutor_id { get => tutor_id; set => tutor_id = value; }
        public string Tutor_nombre { get => tutor_nombre; set => tutor_nombre = value; }
        public int Ubicacion_id { get => ubicacion_id; set => ubicacion_id = value; }
    }
}
