using finalZoo.Datos;
using finalZoo.Animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalZoo.Control
{
    public class ControlAnimal
    {

        public static void IngresarAnimal(Animales.Nombre nombre1)
        {
            AccesoDatosZoo.IngresarAnimal(nombre1);
        }

        internal static List<Animales.Clasificacion> ObtenerClasificacion()
        {
            return AccesoDatosZoo.ObtenerClasificacion();
        }

       /* internal static List<Animales.EnviarEnfermeria> ObtenerEnviarEnfermeria()
        {
            return AccesoDatosPaciente.ObtenerEstadosCiviles();
        }*/

        /*internal static List<Animales.Nombre> ObtenerNombre()
        {
            return AccesoDatosZoo.ObtenerNombre();
        }*/
    }
}
