using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using finalZoo.Animales;



namespace finalZoo.Datos
{
    class Inicializador : DropCreateDatabaseIfModelChanges<Context>
    {

        protected override void Seed(Context context)
        {
            context.clasificacion1.Add(new Clasificacion() { Nombre = "MAMIFERO", Id = 1 });
            context.clasificacion1.Add(new Clasificacion() { Nombre = "ACUATICO", Id = 2 });
            context.clasificacion1.Add(new Clasificacion() { Nombre = "AVE", Id = 3 });

            /*context.Add(new EnviarEnfermeria() { Nombre = "Soltero", Id = 1 });
            context.EnviarEnfermeria.Add(new EstadoCivil() { Nombre = "Casado", Id = 2 });*/

            base.Seed(context);
        }
    }
}
