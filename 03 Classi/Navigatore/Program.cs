using System;
using Consoleapp2.models;


namespace Navigatore
{
    public class Program
    {
        static void Main(string[] args)
        {
            Prova tomtom = new Prova(); //crea istanza dell oggetto navigatore
            Prova garmin = new Prova("garmin",50,"v2.2");

            
            Console.WriteLine(tomtom.Informazioni()); //Invoca il metodo di istanza
            Console.WriteLine(garmin.Informazioni()); //Invoca il metodo di istanza
            Console.Read();


        }



    }


}
