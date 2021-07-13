using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO
{
    public class Ubicacion
    {
        private int id;
        private string area;
        private int camas;

        public int Id { get => id; set => id = value; }
        public string Area { get => area; set => area = value; }
        public int Camas { get => camas; set => camas = value; }
    }
}
