using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioneVeicoli
{
    public class Camion : Veicolo
    {
        public int CapacitaCarico { get; set; }
        public override string TipoVeicolo => "Camion";

        public override void VisualizzaDettagli()
        {
            base.VisualizzaDettagli();
            Console.WriteLine($"Capacità di carico: {CapacitaCarico} tonnellate");
        }
    }

}
