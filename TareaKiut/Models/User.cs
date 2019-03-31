using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TareaKiut.Models
{
    public class User
    {

        [DisplayName("Cedula")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string IdNational { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Name { get; set; }

        [DisplayName("Apellido")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string LastName { get; set; }

        [DisplayName("Correo Electronico")]
        [EmailAddress]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Email { get; set; }

        [DisplayName("Edad")]
        [Range(15, 100)]
        public int Age { get; set; }

        [DisplayName("Estado Civil")]
        public string Status { get; set; }

        [DisplayName("Carrera")]
        public string Career { get; set; }

        [DisplayName("Numero De Telefono")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string PhoneNumber { get; set; }

        [DisplayName("Hobbys")]
        public string[] Hobbys { get; set; }

        [DisplayName("Género:")]
        public string Genero { get; set; }

    }
}
