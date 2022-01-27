using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static double ConvertionTemps(double hours, double minutes, double secondes)
        {

            hours = minutes * 60;
            minutes = secondes = 60;



            return hours ;
        }



        static void convertionTemps(double hours,double minutes,double secondes)
        {
           
            Console.WriteLine("le temps exprimé en " + hours );
            Console.WriteLine("le temps exprime en " + minutes);
            Console.WriteLine("le temps expirmé en " + secondes);

        }



    }

}
        
        
        
        
        