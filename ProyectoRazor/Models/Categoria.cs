using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoRazor.Models
{
    [Table("CATEGORIA")]
    public class Categoria
    {
        [Key]
        [Column("ID_CATEGORIA")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCategoria { get; set; }
        [Column("Nombre")]
        public String Nombre { get; set; }
    }
}