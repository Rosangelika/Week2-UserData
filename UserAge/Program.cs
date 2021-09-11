using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust; 
            //programm arvutab kasutaja sünniaastat; 
            //programm kuvab sünniaastat konsoolis
            //"oled sündinud aastal 1996"


            Console.WriteLine("Tere! Esimene iseseisev töö katsetus.");

            Console.WriteLine("Palun, sisesta oma vanus:");

            int dateOfAge = Convert.ToInt32(Console.ReadLine());

            int userYear = 2021 - dateOfAge;

            //Console.WriteLine("Oled " + userYear + " aastal sündinud.");

            //string interpolation

            Console.WriteLine($"Oled {userYear} aastal sündinud.");




        }
    }
}
