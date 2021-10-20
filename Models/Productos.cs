using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pc3practica.Models
{
    [Table("t_product")]
    public class Productos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}

        [Required(ErrorMessage = "Por favor ingrese nombre de producto")]

        [Display(Name="Nombre Producto")]
        public String Name {get; set;}
        

        [Required(ErrorMessage = "Porfavor ingrese el precio")]
        [Display(Name="Precio")]
        public Decimal Price { get; set; }

        [Required(ErrorMessage = "Porfavor ingrese la imagen")]
        [Display(Name="Imagen de Producto")]
        public String ImagenName { get; set; }

        [Required(ErrorMessage = "Please enter Categoria")]
        public String Categoria { get; set; }

         [Required(ErrorMessage = "Please enter telefono")]
        public Decimal telefono { get; set; }

         [Required(ErrorMessage = "Please enter Descripcion")]
        public String Descripcion { get; set; }

         [Required(ErrorMessage = "Please enter Nombre del Cliente ")]
        public String NombreC { get; set; }

         [Required(ErrorMessage = "Please enter Lugar")]
        public String Lugar { get; set; }


    }
}