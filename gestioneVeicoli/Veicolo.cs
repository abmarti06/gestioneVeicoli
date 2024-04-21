using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioneVeicoli
{
    public abstract class Veicolo
    {
        public int IdVeicolo { get; set; }
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int AnnoImmatricolazione { get; set; }
        public abstract string TipoVeicolo { get; }

        public virtual void VisualizzaDettagli()
        {
            Console.WriteLine($"ID: {IdVeicolo}, Marca: {Marca}, Modello: {Modello}, Anno di immatricolazione: {AnnoImmatricolazione}");
        }
    }
}
