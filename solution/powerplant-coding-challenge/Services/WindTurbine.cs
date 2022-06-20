using System;

namespace PowerPlantCodingChallenge.Services
{
    public class WindTurbine : FuelEngineAbstract
    {
        public override double CalculatePower()
        {
            return Math.Round(PowerPlant.Efficiency * PowerPlant.PMax * (Fuels.Wind / 100), 1);
        }
        public override double CalculatePrice()
        {
            return 0;
        }

        public override double CalculateCo2()
        {
            return 0;
        }
    }
}