using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ABM.Datos
{
    public class JugadorMetadata
    {
        [Required(ErrorMessage = "Ingrese el Apellido")]
        public string Apellido { get; set; }

        [Required]
        [Range(18, 40)]
        public int Edad { get; set; }
    }
}