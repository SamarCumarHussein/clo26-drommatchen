public class Match
{ 
 
  // Privata fält
   private string _hemmalag;
   private string _bortalag;
   private string _datum;


    // Gamla sättet att skriv, den moderna sättet hade varit i en rad, trodde först att man skulle använda.
    // Properties — publik get, privat set


    // get och privat set för Hemmalag
    public string Hemmalag 
    {
       get { return _hemmalag; } private set { _hemmalag = value; }

    }

    // get och privat set för Bortalag
    public string Bortalag

    {
        get { return _bortalag; } private set { _bortalag = value; } 
    }

    // get och privat set för Datum
    public string Datum
    { 

     get { return _datum; } private set { _datum = value; }
           
     }

    // Pluspoäng om ni kommer på hur man kan minska ner koden med properties :)
    // det hade varit att man t.ex. skriv public string hemmalag { get; private set; }

    // Konstruktor
    public Match(string hemmalag, string bortalag, string datum)
    {
        // TODO: tilldela de privata fälten.
        _hemmalag = hemmalag;
        _bortalag = bortalag;
        _datum = datum;
        
    }

    // Metod 1: skriv ut matchens lag och datum
    public void Presentera()
    {  
        // TODO
        Console.WriteLine($"{_hemmalag}  vs  {_bortalag}  {_datum}");
       
    }

    // Metod 2: skriv ut spelarens namn, nummer och position
    public void AnnounceraMålskytt(Spelare spelare)
    {
        // TODO

    }
}
