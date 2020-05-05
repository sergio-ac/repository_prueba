using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace plataforma_web.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "El campo nid es obligatorio")]
        public string NID { get; set; }
        [Required(ErrorMessage = "El campo telefono es obligatorio")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-, ]?([0-9]{2})[-, ]?([0-9]{5})$", ErrorMessage = "El formato telefono ingresado no es válido.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="El campo correo electronico es obligatorio")]
        [EmailAddress(ErrorMessage ="El correo electronico no es una dirección de correo electronico válida")]
        public string Email { get; set; }
        [Display(Name="Contraseña")]
        [Required(ErrorMessage ="El campo contraseña es obligatorio")]
        [StringLength(100,ErrorMessage ="El numero de caracteres de {0} debe ser al menos {2}.",MinimumLength =6)]
        public string Password { get;set; }


    }
}
