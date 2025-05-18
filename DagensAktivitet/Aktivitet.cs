using DagensAktivitet;

Aktivitet.VelgAktivitet();

namespace DagensAktivitet
{
    public class Aktivitet
    {
        public static string Mandag = "Start uken med en rolig spasertur.";
        public static string Tirsdag = "Tid for en treningsøkt!";
        public static string Onsdag = "Midtuke – kanskje en god bok?";
        public static string Torsdag = "Snart helg! Planlegg noe gøy.";
        public static string Fredag = "Filmkveld!";
        public static string Lørdag = "Utforsk naturen eller besøk venner.";
        public static string Søndag = "Slapp av og lad opp for neste uke.";
        
        public Aktivitet()
        {
 
        }
        
        public static void VelgAktivitet()
        {
            Console.WriteLine("Nå skal vi velge akktivitet som passer for dagen. Skriv vilken dag det er");
            string input = Console.ReadLine()?.ToLower();

            if (input == "mandag")
            {
                Console.WriteLine($"Forslag: {Mandag}");
            }
            else if (input == "tirsdag")
            {
                Console.WriteLine($"Forslag: {Tirsdag}");
            }
            else if (input == "onsdag")
            {
                Console.WriteLine($"Forslag: {Onsdag}");
            }
            else if (input == "torsdag")
            {
                Console.WriteLine($"Forslag: {Torsdag}");
            }
            else if (input == "fredag")
            {
                Console.WriteLine($"Forslag: {Fredag}");
            }
            else if (input == "lørdag")
            {
                Console.WriteLine($"Forslag: {Lørdag}");
            }
            else if (input == "søndag")
            {
                Console.WriteLine($"Forslag: {Søndag}");
            }
            else
            {
                Console.WriteLine("Beklager, det er ikke en gyldig ukedag.");
            }
        }
    }
}