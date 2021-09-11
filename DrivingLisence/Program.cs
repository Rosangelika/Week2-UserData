using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat; 
            //programm arvutab kasutaja vanust; 
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis "Oled liiga noor, et juhiluba saada"; 
            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis "Oled piisavalt vana, et juhilube saada"; 
            //kui kasutaja on 18, siis programm kuvab konsoolis "Palju õnne! Nüüd sa saad juhilube taotleda". 

            Console.WriteLine("Tere! Aitäh, et kasutate Rosangelika poolt loodud süsteemi juhilubade taotlemisel :)");

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;


            if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhiluba saada.");
            }
            else if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }
            else 
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad juhilube taotleda.");
            }

            Console.WriteLine("Ohutut liiklemist!");
            

        }
    }
}
