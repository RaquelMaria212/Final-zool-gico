using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using finalZoo.Animales;
using finalZoo.Datos;


namespace finalZoo.Datos
{
    class AccesoDatosZoo
    {
        private static Context context = new Context();

        public static void IngresarAnimal(Nombre nombre1)
        {
            context.Nombre.Add(nombre1);
            context.SaveChanges(); //guardar cambios
        }

        internal static List<Clasificacion> ObtenerClasificacion()
        {
            return context.clasificacion1.ToList();
        }

        /*internal static List<EnviarEnfermeria> ObtenerEstadosCiviles()
        {
             return context.EstadosCiviles.ToList();
        }

        internal static List<Nombre> ObtenerPacientes()
        {
            return context.nombresito.ToList();
        }*/



    }
}
