namespace PowerPlantCodingChallenge.Models
{
    public class PayLoad
    {
        /// <summary>
        /// The load is the amount of energy (MWh) that need to be generated during one hour
        /// </summary>
        public double Load { get; set; }
        public Fuels Fuels { get; set; }
        public PowerPlant[] PowerPlants { get; set; }
    }
}