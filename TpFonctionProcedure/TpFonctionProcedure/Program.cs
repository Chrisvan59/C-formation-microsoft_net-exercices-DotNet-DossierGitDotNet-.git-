// See https://aka.ms/new-console-template for more information

using System;
namespace MyApp // Note: actual namespace depends on the project name 
{
    internal class Program
    {


        static void Main(string[] args)
        {
            AffichageNomAge("Nizar", "age");

        }
        static void AffichageNomAge(string prenom, string age)
        {
            Console.WriteLine("Vous vous appeler" + prenom);
            Console.WriteLine("Bientous vous aurez " + age);

        }
    }
}
