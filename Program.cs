// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Geben sie eine Zahl von 1-100 ein, wenn sie beim ersten Versuch unsere Geheime Zahl erraten gewinnen sie 100.-(Sie haben insgesamt 1 Versuche)");
int Zahl = Convert.ToInt32(Console.ReadLine());
if (Zahl == 57)
{

    Console.WriteLine("GLÜCKWUNSCH SIE HABEN 100.- GEWONNEN!");
    Console.WriteLine("Glückwunsch sie haben unsere Zahl erraten und diesen Level überschrieten");
    Console.WriteLine("Wollen sie weiterfahren");
    String Fortfahren = Convert.ToString(Console.ReadLine());

    if (Fortfahren == "Ja")
    {

        Random myObject = new Random();
        int Random = myObject.Next(1, 100);
        Console.WriteLine("Hier ist Ihre Random Zahl:");
        Console.WriteLine(Random);
        Console.WriteLine("Wollen Sie nochmal ein neues Spiel spielen?");
        String NeuesSpiel = Convert.ToString(Console.ReadLine());
        if(NeuesSpiel == "Ja")
        {

            Console.WriteLine("wollen sie nochmal ein neues Spiel spielen?");
            string fortfahren = Console.ReadLine();
            while (fortfahren == "Ja")


            {
                int meineZahl = 3;
                Console.WriteLine("Geben sie eine Zahl zwischen 1-120 ein um unsere geheime Zahl zu erraten");
                int versuch1 = Convert.ToInt32(Console.ReadLine());


                if (versuch1 < meineZahl)
                {
                    Console.WriteLine("Ihre geratene Zahl ist zu klein, geben Sie eine grössere Zahl ein  ");


                }
                else if (versuch1 > meineZahl)
                {
                    Console.WriteLine("Ihre geratene Zahl ist zu gross, geben sie eine kleinere Zahl ein");


                }
                if (versuch1 == 3)
                {
                    Console.WriteLine("Glückwunsch Sie haben unsere geheime Zahl richtig erraten");


                }
            }
}
else
{

    Console.WriteLine("Ihre geratene Zahl ist leider Falsch. Wollen sie ein neues Spiel spielen?");
    String FortFahren = Convert.ToString(Console.ReadLine());

    if (FortFahren == "Ja")
    {
        Random myObject1 = new Random();
        int Random1 = myObject.Next(1, 100);
        Console.WriteLine("Hier ist Ihre Random Zahl:");
        Console.WriteLine(Random);

    }
     
               
                else
                {
                    Console.WriteLine("Schade, wir sehen  uns beim nächsten mal");


                    
                    
                   

                        }
    
                    }
                }
            }




















    




