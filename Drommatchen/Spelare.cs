    public class Spelare
    {
  
     // Privata fält
        private string _namn;
        private int _nummer;
        private string _position;

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
            _namn = namn;
            _nummer = nummer;
            _position = position;
           
        }
    }

