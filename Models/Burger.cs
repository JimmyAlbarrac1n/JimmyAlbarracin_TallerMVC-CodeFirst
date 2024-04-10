using System.ComponentModel.DataAnnotations;

namespace JimmyAlbarracin_TallerMVC_CodeFirst.Models
{
    public class Burger
    {
        public int Id { get; set; } //ID obligatorio 
        [Required]//campo obligatorio
        public string? Name { get; set; } //? en el string sirve para contener valores nulos
        public bool WithCheese { get; set; }
        [Range(0.01, 9999.99)]//validaciones para la base de datos
        public decimal Precio { get; set; }
    }
}
