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

        /* 
        public Opleiding()
        {
            this.afkortingCampus = this.campus.Substring(0,3);
        }

        public override string ToString()
        {
            return string.Format("Campus {0} - campusnummer {1}", this.campus, this.campusNummer);
        }
        public override void GeefInformatie()
        {
            
           
        }

        */
    } 
}