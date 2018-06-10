using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalZoo.Animales
{
    [Table("Clasificacion")]
    public class Clasificacion
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Nombre> nombresito { get; set; }
    }
}
