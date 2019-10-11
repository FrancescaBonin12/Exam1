using System;
using System.Collections.Generic;
using System.Text;

namespace Esame1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> prodotti = new List<Product>();

            //Numeri.InserisciNumerosuconsole();
            int numpersone = ConsoleUtils.LeggiNumeroInteroDaConsole(1, 10);

           // Product.AggiungiPersonaARubricaInPosizione(prodotti, numpersone);


            for (int i= 0; i < numpersone; i++)
            {
                Product.AggiungiPersonaARubricaInPosizione(prodotti, numpersone);
            }


               //Stampa lista

                for (var i = 0; i < prodotti.Count; i++)
                {
                    Console.WriteLine($" Dopo ogni prodotto premi invio {prodotti[i].FirstName}, {prodotti[i].ID}");
                     Console.ReadLine();
                    
                }



            Scrividentrofile.AssicuratiCheEsistaCartellaDiArchivio();
           





        }




    }
}

















