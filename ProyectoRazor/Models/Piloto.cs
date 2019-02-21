using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoRazor.Models
{
    [Table("PILOTOS")]
    public class Piloto
    {
        [Key]
        [Column("ID_PILOTO")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPiloto { get; set; }
        [Column("DORSAL")]
        public int Dorsal { get; set; }
        [Column("NOMBRE")]
        public String Nombre { get; set; }
        [Column("APELLIDO")]
        public String Apellido { get; set; }
        [Column("EQUIPO")]
        public int Equipo { get; set; }
        [Column("CATEGORIA")]
        public int Categoria { get; set; }
        [Column("TITULOS")]
        public int Titulos { get; set; }
        [Column("DEBUT")]
        public int Debut { get; set; }
    }
}