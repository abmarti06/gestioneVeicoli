using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioneVeicoli
{
    public class Flotta
    {
        public int IdFlotta { get; set; }
        public List<Veicolo> ListaVeicoli { get; set; }

        public Flotta()
        {
            ListaVeicoli = new List<Veicolo>();
        }

        public void AggiungiVeicolo(Veicolo veicolo)
        {
            ListaVeicoli.Add(veicolo);
        }

        public void RimuoviVeicolo(int indice)
        {
            if (indice >= 0 && indice < ListaVeicoli.Count)
            {
                ListaVeicoli.RemoveAt(indice);
            }
            else
            {
                Console.WriteLine("Indice non valido.");
            }
        }

        public void VisualizzaVeicoli()
        {
            foreach (var veicolo in ListaVeicoli)
            {
                veicolo.VisualizzaDettagli();
            }
        }
    }
}
