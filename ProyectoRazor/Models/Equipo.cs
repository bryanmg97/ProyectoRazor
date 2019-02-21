using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoRazor.Models
{
    [Table("EQUIPOS")]
    public class Equipo
    {
        [Key]
        [Column("ID_EQUIPO")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEquipo { get; set; }
        [Column("NOMBRE")]
        public String Nombre { get; set; }
        [Column("CATEGORIA")]
        public int Categoria { get; set; }
    }
}