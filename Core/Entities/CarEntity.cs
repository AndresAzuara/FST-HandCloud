using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities
{
    public class CarEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "El máximo son 50 caracteres"), Required(ErrorMessage = "Debes ingresar el modelo")]
        public string Model { get; set; }
        [MaxLength(100, ErrorMessage = "El máximo son 100 caracteres")]
        public string Description { get; set; }
        [Range(0, 9000, ErrorMessage = "Puedes agregar en un rango de 0 - 9000")]
        public int Year { get; set; }
        [MaxLength(50, ErrorMessage = "El máximo son 50 caracteres"), Required(ErrorMessage = "Debes ingresar el brand")]
        public string Brand { get; set; }
        [Range(0, 1000000, ErrorMessage = "Puedes agregar en un rango de 0 - 1000000"), Required(ErrorMessage = "Debes ingresar el kilometraje")]
        public int Kilometers { get; set; }
        [Range(0.0, 10000000.0, ErrorMessage = "Puedes agregar en un rango de 0.0 - 10000000.0"), Required(ErrorMessage = "Debes ingresar el precio")]
        public decimal Price { get; set; }
    }
}
