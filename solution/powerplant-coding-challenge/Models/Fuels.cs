namespace PowerPlantCodingChallenge.Models
{
    public class Fuels
    {
        /// <summary>
        /// Gas (euro/MWh) 
        /// </summary>
        public double Gas { get; set; }
        /// <summary>
        /// Kerosine (euro/MWh) 
        /// </summary>
        public double Kerosine { get; set; }
        /// <summary>
        /// Co2 (euro/ton) 
        /// </summary>
        public double Co2 { get; set; }
        /// <summary>
        /// Wind (%) 
        /// </summary>
        public double Wind { get; set; }
    }
}