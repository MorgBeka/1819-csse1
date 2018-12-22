class Voertuig
{
    //velden
    //properties
    //methods
    //constructors
    //...

    private int laadvermogen;
    //private bool motor;
    // private string brandstof;
    //merk

//properties

    // int Laadvermogen
    // {
    //   get;
    //   set;
    // }

    public int Laadvermogen
    { 
        get 
       {
        return laadvermogen;
       } 
       set 
       {
           laadvermogen=value;
       }
        
    }

    public string Motor { get; set;}
    public string Kleur { get; set;}
    
    //Constructor 
    public Voertuig(int laadvermogen, string kleur)
    {
        // Laadvermogen = laadvermogen;
        this.laadvermogen = laadvermogen;
        Kleur = Kleur;
    }

    public Voertuig()
    {


    }
    
    //uitlezen
    public string ToString()
    {
        return "Voertuig met laadvermogen: " + this.laadvermogen + ", met kleur: " + this.Kleur;
    }
}