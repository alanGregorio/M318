using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06_Fumetto.Models; 

namespace _06_Fumetto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserire la quantita di fumetti desiderata"); 
            int valore = Convert.ToInt32(Console.ReadLine());
            Fumetto[] fumetti = new Fumetto[valore];
            string titolo;
            string autore;
            int annoPubblicazione;
            int prezzo;
            string breveDescrizione;
            int isbn;
            bool stato;
            for(int i = 0; i < fumetti.Length; i++) {

                Console.WriteLine("Inserire il titolo");
                titolo = Console.ReadLine();
                Console.WriteLine("Inserire l'autore");
                autore = Console.ReadLine();
                Console.WriteLine("Inserire l'anno di pubblicazione");
                annoPubblicazione = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserire il prezzo");
                prezzo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserire una breve descrizzione");
                breveDescrizione = Console.ReadLine();
                Console.WriteLine("Inserire l'ISBN");
                isbn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserire lo stato");
                stato = Convert.ToBoolean(Console.ReadLine());

                fumetti[i] = new Fumetto(titolo,autore,annoPubblicazione,prezzo,breveDescrizione,isbn,stato);
          
            
            }
            while (true)
            {
                int temp = 0;
                Console.WriteLine("************GESTIONE FUMETTI************\n" +
                    "01 --> Modifica Prezzo\n"+
                    "02 --> Modificare lo stato\n"+ 
                    "03 --> Modificare la descrizione\n"+ 
                    "04 --> Stampa la lista dei fumetti"
                    );

                temp = Convert.ToInt32(Console.ReadLine());
                if(temp == 1)
                {

                }else if(temp == 2)
                {

                }else if (temp == 3)
                {

                }else if (temp == 4)
                {

                    Console.WriteLine("{0,-20}|{1,-20}|{2,-10}|{3,-10}|{4,-10}|", "Titolo", "Autore", "AnnoP", "prezzo", "stato");
                    for (int i = 0;i < fumetti.Length; i++)
                    {
                        
                        Console.WriteLine(fumetti[i]);

                    }
                    Console.WriteLine("Premi qualsiasi tanto per continuare");
                    Console.ReadKey();
                }
            }
            
    }
    }
}
