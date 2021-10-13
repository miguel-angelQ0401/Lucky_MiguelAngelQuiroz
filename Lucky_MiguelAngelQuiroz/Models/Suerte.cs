using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky_MiguelAngelQuiroz.Models
{
    public class Suerte
    {
        [Key]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "La longitud de {0} debe ser entre {2} y {1}")]
        public int SuerteId { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "El {0} es requerido")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "La longitud de {0} debe ser entre {2} y {1}")]
        public string Detalle { get; set; }
        [Url]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "La longitud de {0} debe ser entre {2} y {1}")]
        public string URL { get; set; }
    }
}
