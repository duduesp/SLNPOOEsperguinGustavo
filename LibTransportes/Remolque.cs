using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Remolque
    {
        public string Color { get; set; }
        public bool Conectado { get; set; }

        public Remolque(string color, bool conectado)
        {
            Color = color;
            Conectado = conectado;
        }

        public virtual string ImprimirRemolque()
        {
            return "El remolque ha sido creado correctamente";
        }
    }
}
