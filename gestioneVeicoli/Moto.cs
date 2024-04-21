using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioneVeicoli
{
    public class Moto : Veicolo
    {
        public int Cilindrata { get; set; }
        public override string TipoVeicolo => "Moto";

        public override void VisualizzaDettagli()
        {
            base.VisualizzaDettagli();
            Console.WriteLine($"Cilindrata: {Cilindrata}cc");
        }
    }
}
