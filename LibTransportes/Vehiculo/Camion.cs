using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Vehiculo
{
    public class Camion : Vehiculo
    {
        public string Carga { get; set; }

        public bool Activo { get; set; }

        public Camion(int ruedas, string modelo, string carga, bool activo) :base(ruedas, modelo)
        {
            Carga = carga;
            Activo = activo;
        }
        public Remolque remolque { get; set; }

        public virtual string QuitarRemolque()
        {
            remolque = null;
            return "Se ha quitado el remolque";
        }
        public override string Acelerar()
        {
            return base.Acelerar() + "\nEl camión aceleró";
        }
        public override string Frenar()
        {
            return base.Frenar() + "\nEl camión frenó";
        }

        public virtual string ImprimirCamión()
        {
            return "El camión ha sido creado correctamente";
        }
    }
}
