using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proyecto_pro_3_api.Models
{
    public class Docente : Persona
    {
        

        public string Egresado { set; get; }

        [Required]
        public string Cargo { set; get; }

        
    }
}