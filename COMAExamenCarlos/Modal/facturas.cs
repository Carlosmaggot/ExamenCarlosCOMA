using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMAExamenCarlos.Modal
{
    public class facturas
    {
        [Key]
        public int Id { get; set; } // Idenficador

        public int id_usuario { get; set; } // idenficicador de los usuarios

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string folio { get; set; } // folio
        public int saldo { get; set; } // saldo
        public string fecha_facturacion { get; set; } // fecha facturacion
        public string fecha_creacion { get; set; } // fecha de creacion
    }
}
