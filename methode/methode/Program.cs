// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
internal class Program
{
    static void Main(string[] args)
    {
        int taille = 100;
        Plus10Centimetre(ref taille);
        Console.WriteLine("en dehors de la methode" + taille);
    }
    static void Plus10Centimetre( ref int data)
    {
        data = data + 10;
        Console.WriteLine("Dans la methode" + data);
    }
}