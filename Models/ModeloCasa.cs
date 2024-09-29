using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA.Models
{
    public class ModeloCasa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public  bool CocheraTechada { get; set; }

        public int CantDormitorios { get; set; }

        public int CantBanios { get; set; }

        public bool EsDeDosPlantas { get; set; }

        
    }
}
