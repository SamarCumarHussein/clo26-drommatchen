    public class Spelare
    {
     // Kollade på förläsningar för att hitta hur du skulle vilja har, jag skrivit tidagre som auto-properties. 
     // fattade att det va en full properties som krävdes för ger koll på vad som lagras.
     //Privata fält
        private string _namn;
        private int _nummer;
        private string _position;

        // Skapa get och privat set för Namn
    
        public string Namn 
        { 
            get { return _namn; } private set { _namn = value; }
        }
       
        // Skapa get och privat set för Nummer
        public int Nummer 
        {  
           get { return _nummer; } private set { _nummer = value; }
    
        }

        // Skapa get och privat set för Position.
        public string Position
        {
            get { return _position; } private set { _position = value; }
        }

        // Konstruktor
        public Spelare(string namn, int nummer, string position)
        {
        // TODO: tilldela de privata fälten
            _namn = namn;
            _nummer = nummer;
            _position = position;
           
        }
    }

