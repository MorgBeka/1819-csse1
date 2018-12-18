namespace deel2
{
    public class Opleiding : AbstractInfo, AbstractDetail, IInformatie
    {
        private string afkortingCampus;
        protected int campusNummer;
        public string campus
        {
            get;
            set;
        }
        public string Opleidingsnaam
        {
            get;
            set;
        }
        string GetWifiCode()
        {
            return "code";
        }

        public Opleiding(){
            this.afkortingCampus = this.campus.Substring(0,3);
        }

        public override void GeefInformatie(){

        }

        
    } 
} 