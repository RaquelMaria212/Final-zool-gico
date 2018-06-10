using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalZoo.Animales
{
    public class Nombre
    {
        public string nombre { get; set; }
        public virtual Nombre nombresito { get; set; }
        public long NumeroRegistro { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int EdadEnAños { get; set; }
        
        public string Especie { get; set; }
        public string SubEspecie { get; set; }

        public int IdClasificación { get; set; }
        public virtual Clasificacion clasificacion1 { get; set; }

        public int IdEnviarEnfermeria { get; set; }


        public string CostumbresAlimenticias { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Diagnostico { get; set; }

        //public virtual EstadoCivil EstadoCivil { get; set; }

    }
}
