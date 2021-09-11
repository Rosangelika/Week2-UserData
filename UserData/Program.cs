using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //pragramm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust kosnoolist;

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana.");

        }
    }
}
