using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioneVeicoli
{
    public class Auto : Veicolo
    {
        public int NumeroPorte { get; set; }
        public override string TipoVeicolo => "Auto";

        public override void VisualizzaDettagli()
        {
            base.VisualizzaDettagli();
            Console.WriteLine($"Numero di porte: {NumeroPorte}");
        }
    }
}
