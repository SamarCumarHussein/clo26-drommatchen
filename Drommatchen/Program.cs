using System;

class program
{
    static void Main()
    {

        // TODO: Skapa minst 2 spelare
        // Spelare spelare1 = new Spelare("Namn", nummer, "Position");
        
        Spelare Spelare1 = new Spelare("Zlatan Ibrahimović", 10, "Forward");

       // Spelare spelare2 = new Spelare(...);
        Spelare Spelare2 = new Spelare("Haaland Erling", 9, "Forward");

        // TODO: Skapa 1 match
        // Match match = new Match("Hemmalag", "Bortalag", "Datum");
        Match match = new Match("Drömlaget FC", "Värdselvan", "2026-09-19");

        // TODO: Anropa match.Presentera()
        match.Presentera();

        // TODO: Anropa match.AnnounceraMålskytt() med båda spelarna
        match.AnnounceraMålskytt(Spelare1);
        match.AnnounceraMålskytt(Spelare2);
    }
}


        
       








