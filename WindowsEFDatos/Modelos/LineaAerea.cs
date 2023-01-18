﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFDatos.Modelos
{
    public class LineaAerea
    {
        [Key]
        public int IdLinea { get; set; }



        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }


        public DateTime FechaInicioActividades { get; set; }


        public List<Avion> Aviones { get; set; }

        //public LineaAerea(int idLinea, string nombre, DateTime fechaInicioActividades, List<Avion> aviones)
        //{
        //    IdLinea = idLinea;
        //    Nombre = nombre;
        //    FechaInicioActividades = fechaInicioActividades;
        //    Aviones = aviones;
        //}
    }
}
