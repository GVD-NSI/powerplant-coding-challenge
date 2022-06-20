namespace PowerPlantCodingChallenge.Models
{
    public class PowerPlant
    {
        /// <summary>
        /// The name of the powerplant
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type (gasfired, turbojet or windturbine)
        /// </summary>
        public FuelType Type { get; set; }
        /// <summary>
        /// the efficiency at which they convert a MWh of fuel into a MWh of electrical energy.
        /// Wind-turbines do not consume 'fuel' and thus are considered to generate power at zero price.
        /// </summary>
        public double Efficiency { get; set; }
        /// <summary>
        /// The maximum amount of power the powerplant can generate.
        /// </summary>
        public double PMax { get; set; }
        /// <summary>
        /// The minimum amount of power the powerplant generates when switched on.
        /// </summary>
        public double PMin { get; set; }
    }
}