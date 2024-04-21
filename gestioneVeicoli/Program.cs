using System;

namespace gestioneVeicoli
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Flotta flotta = new Flotta();

            // Esempio di utilizzo del programma
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Aggiungi veicolo");
                Console.WriteLine("2. Visualizza veicoli");
                Console.WriteLine("3. Rimuovi veicolo");
                Console.WriteLine("4. Esci");

                Console.Write("Selezione un'opzione: ");
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Console.WriteLine("Inserisci il tipo di veicolo (Auto, Moto, Camion): ");
                        string tipo = Console.ReadLine();
                        Veicolo nuovoVeicolo = null;
                        switch (tipo)
                        {
                            case "Auto":
                                nuovoVeicolo = new Auto();
                                break;
                            case "Moto":
                                nuovoVeicolo = new Moto();
                                break;
                            case "Camion":
                                nuovoVeicolo = new Camion();
                                break;
                            default:
                                Console.WriteLine("Tipo di veicolo non valido.");
                                continue;
                        }
                        Console.Write("Marca: ");
                        nuovoVeicolo.Marca = Console.ReadLine();
                        Console.Write("Modello: ");
                        nuovoVeicolo.Modello = Console.ReadLine();
                        Console.Write("Anno di immatricolazione: ");
                        nuovoVeicolo.AnnoImmatricolazione = int.Parse(Console.ReadLine());
                        flotta.AggiungiVeicolo(nuovoVeicolo);
                        break;
                    case "2":
                        flotta.VisualizzaVeicoli();
                        break;
                    case "3":
                        Console.Write("Inserisci l'indice del veicolo da rimuovere: ");
                        int indiceRimozione = int.Parse(Console.ReadLine());
                        flotta.RimuoviVeicolo(indiceRimozione);
                        break;
                    case "4":
                        // Salvataggio dei dati su file qui
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Selezione non valida.");
                        break;
                }
            }
        }
    }
}
