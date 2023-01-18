using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LibTransportes.Vehiculo
{
    public class AutoElectrico : Vehiculo
    {
        public string TipoCarga { get; set; }

        public int Patente { get; set; }

        public AutoElectrico(int ruedas, string modelo, string tipocarga, int patente) : base(ruedas, modelo)
        {
            TipoCarga = tipocarga;
            Patente = patente;
        }

        public override string Acelerar()
        {
            return base.Acelerar() + "\nEl auto eléctrico aceleró";
        }

        public override string Frenar()
        {
            return base.Frenar() + "\nEl auto eléctrico frenó";
        }

    }
}
