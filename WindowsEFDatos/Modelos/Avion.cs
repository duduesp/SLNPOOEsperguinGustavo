using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFDatos.Modelos
{
    public class Avion
    {
        [Key]
        public int IdAvion { get; set; }

        public int Capacidad { get; set; }


        [Column(TypeName ="varchar")]
        [StringLength(50)]
        [Required]
        public string Denominacion { get; set; }

        //public Avion(int capacidad, string denominacion)
        //{
        //    Capacidad = capacidad;
        //    Denominacion = denominacion;
        //}
        public LineaAerea LineaAerea { get; set; }
    }
}
