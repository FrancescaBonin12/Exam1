using System;
using System.Collections.Generic;
using System.Text;

namespace Esame1
{
    class Product
    {

        public string ID { get; set; }
        public string FirstName { get; set; }


       // List<Product> prodotti = new List<Product>();  
    

     
    public static void AggiungiPersonaARubricaInPosizione(List<Product> prodotti,  int numpersone)
    {
        //5) Richiedo il nome e cognome della persona
        Console.Write("ID: ");
        var codice = Console.ReadLine();
        Console.Write("Nome: ");
        var nome = Console.ReadLine();

        //6) Creo oggetto Product da inserire in rubrica
        Product product = new Product
        {
            ID = codice,
            FirstName = nome
        };

            
        //7) Aggiungo persona a rubrica
        prodotti.Add(product);
        

        
            



        }


    }
}







