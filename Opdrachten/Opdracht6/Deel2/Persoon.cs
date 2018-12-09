using System;
namespace deel2
{
    public class Persoon : Gebruiker, Informatie
    {
        private string naam;
        private string voornaam;
        public string Naam
        {
            get 
            {
                return this.naam;
            }
            set 
            {
                this.voornaam = value;
            }
        }

        public string VolledigeNaam
        {
            get;
        }
        public DateTime GeboorteDatum
        {
            get;
            set;
        }
        public int Leeftijd()
        {
            return 0;
        }
        public override string GenereerWachtwoord()
        {
            return "Persoon - wachtwoord";

        }

        public string GenereerWachtwoord(int input)
        {

            return "Test 2";
        } 
        public string GenereerWachtwoord(string input)
        {
            return "Test 1";
        
        }

        /* public int GenereerWachtwoord()
        {
            return "54896465";
        } */
        
        public override string ToString()
        {
            return "waarden van object persoon";
        }
    }

}