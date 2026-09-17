    public class Spelare
    {
    // Gamla sättet att skriva properties i C#.
    // Privata fält
    // private string _namn;
    //private int _nummer;
    // private string _position;


    // Detta är den modernare stilen att skriva properties då man gör alltid i en rad, vilket ändå är samma sak.
    // Properties — publik get, privat set
    public string Namn { get; private set; }
        // Skapa get och privat set för Namn

        public int Nummer { get; private set; }

        // Skapa get och privat set för Nummer

        public string Position { get; private set; }
        // Skapa get och privat set för Position



        // Konstruktor
        public Spelare(string namn, int nummer, string position)
        {
            // TODO: tilldela de privata fälten
            // Hade använde detta om jag hade använt privata fält istället för properties.
           // _namn = namn;
           // _nummer = nummer;
           // _position = position;

            Namn = namn;
            Nummer = nummer;
            Position = position;
        }
    }

