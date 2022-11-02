namespace Testprogram1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print vraag hoogte
            Console.WriteLine("hoogte?");
            // Input hoogte van user
            int hoogte = Convert.ToInt32(Console.ReadLine());
            // Print vraag breedte
            Console.WriteLine("breedte?");
            // Input hoogte van user
            int breedte = Convert.ToInt32(Console.ReadLine()) / 2;
            // Creeeren van variable
            string schaakBordRegel = "";
            char readCharY = 'Y';
            char readCharZ = 'Z';
            // Functie voor creeeren schaakbord breedte lijn
            SchaakbordmakenZ(breedte);
            // Creeer variable voor eerste letter van schaakbord breedte lijn
            char currentChar = schaakBordRegel[0];
            // Functie voor het printen de schaakbord hoogte
            SchaakbordmakenY(hoogte);
            // Functies:
            void SchaakbordmakenZ(int breedte)
            {
                // Creeer variable voor vergelijking
                int zBoard = 0;
                // Creeer breedte regel via loop
                while (zBoard < breedte)
                {
                    // Variable waaruit het schaakbord bestaat
                    schaakBordRegel += "XY";
                    // Variable verhogen van schaakbord loop lijn
                    zBoard++;
                }
            }
            void SchaakbordmakenY(int hoogte)
            {
                int yBoard = 0;

                while (yBoard < hoogte)
                {
                    if (currentChar == readCharY)
                    {
                        // Verwijder eerste letter om schaapbord patroon te creeeren
                        schaakBordRegel = schaakBordRegel[1..];
                        // Print schaakbord regel
                        Console.WriteLine(schaakBordRegel + "Y");
                        // Loop increment voor de juiste lengte van het schaakbord te creeeren
                        yBoard++;
                        // Switch voor de loop omzetten
                        currentChar = readCharZ;
                        // Verwijderde letter weer toevoegen aan de variable
                        schaakBordRegel = schaakBordRegel + "Y";

                    }
                    else
                    {
                        // Verwijder eerste letter om schaapbord patroon te creeeren
                        schaakBordRegel = schaakBordRegel[1..];
                        // Print schaakbord regel
                        Console.WriteLine(schaakBordRegel + "Z");
                        // Loop increment voor de juiste lengte van het schaakbord te creeeren
                        yBoard++;
                        // Switch voor de loop omzetten
                        currentChar = readCharY;
                        // Verwijderde letter weer toevoegen aan de variable
                        schaakBordRegel = schaakBordRegel + "Z";
                    }

                }

            }
        }
    }
}


/*
 * 
 *  void SchaakbordmakenY(int hoogte)
            {
                int yBoard = 0;
                while (yBoard < hoogte)
                {
                    Console.WriteLine(lijnRegel);
                    yBoard++;
                }
            }
 * 
 */


/*
 *     //string b = lijnRegel.Substring(0, 1);
            //lijnRegel += lijnRegel + b;
            // lijnRegel = lijnRegel.Substring(1, lijnRegel.Length);
            // Console.WriteLine("--");
            //  Console.WriteLine(aa);
            // Console.WriteLine("--");
*/