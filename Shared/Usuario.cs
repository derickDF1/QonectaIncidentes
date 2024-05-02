using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonectaIncidentes.Shared
{
    public class Usuario
    {
        [Key] public int IdUsuario {  get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Contrasenia { get; set; } = string.Empty;
        public int IdRol { get; set; }
    }
}
