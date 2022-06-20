using PowerPlantCodingChallenge.Models;

namespace PowerPlantCodingChallenge.Services
{
    public abstract class FuelEngineAbstract
    {
        public string Name { get; set; }
        public PowerPlant PowerPlant { get; set; }
        public Fuels Fuels { get; set; }
        public abstract double CalculatePower();
        public abstract double CalculatePrice();
        public abstract double CalculateCo2();
    }
}