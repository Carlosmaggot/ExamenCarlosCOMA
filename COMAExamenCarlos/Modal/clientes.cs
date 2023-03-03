using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMAExamenCarlos.Modal
{
    public class clientes
    {
        [Key]
        public int Id { get; set; }//Indentificacor

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Nombre { get; set; } // nombre del cliente
        public string Apellido { get; set; } // apellido del cliente
        public int Edad { get; set; } // edad del cliente
        public string Correo_electronico { get; set; } // correo electronico
        public string Tipo_usuario { get; set; } // tipo usuario
    }
}
