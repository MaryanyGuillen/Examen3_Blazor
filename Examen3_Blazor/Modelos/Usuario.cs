using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Usuario
{
    [Required(ErrorMessage = "El campo código es obligatorio")]
    public string Codigo { get; set; }
    [Required(ErrorMessage = "El campo nombre es obligatorio")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "El campo rol es obligatorio")]
    public string Rol { get; set; }
    public string Clave { get; set; }
    public bool EstaActivo { get; set; }
}
