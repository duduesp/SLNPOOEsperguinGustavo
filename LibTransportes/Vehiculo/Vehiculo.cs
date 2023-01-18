using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Vehiculo
{
    public class Vehiculo
    {
        public int Ruedas { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(int ruedas, string modelo)
        {
            Ruedas = ruedas;
            Modelo = modelo;

        }

        public virtual string Frenar()
        {
            return "El auto se ha frenado.";

        }

        public virtual string Acelerar()
        {
            return "El auto ha acelerado.";
        }
    }
}
