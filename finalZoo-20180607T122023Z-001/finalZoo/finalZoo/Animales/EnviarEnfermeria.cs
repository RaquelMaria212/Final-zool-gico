using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using finalZoo.Animales;

namespace finalZoo.Enfermeria
{
    [Table("EnviarEnfermeria")]

    public class EnviarEnfermeria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Nombre> nombresito { get; set; }
    }
}
