namespace deel2
{
    public class Opleiding : AbstractInfo, AbstractDetail, Informatie
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

    } 
} 