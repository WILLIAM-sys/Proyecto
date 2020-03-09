using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proyecto_pro_3_api.Models
{
    public class Persona
    {
        public int ID { set; get; }
        [Required]
        public string Documento { set; get; }
        [Required]
        public string Nombre { set; get; }
        [Required]
        public string Apellido { set; get; }
        [Required]
        public string Carrera { set; get; }
        [Required]
        public string Usuario { set; get; }
        [Required]
        public string Clave { set; get; }
        [Required]
        public string Edad { set; get; }

        [Required]
        public string Rol { set; get; }
    }
}