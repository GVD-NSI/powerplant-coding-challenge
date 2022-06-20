using System;

namespace PowerPlantCodingChallenge.Services
{
    public class GasFired : FuelEngineAbstract
    {
        public override double CalculatePower()
        {
            return Math.Round(PowerPlant.Efficiency * (PowerPlant.PMax - PowerPlant.PMin), 1);
        }

        public override double CalculatePrice()
        {
            return CalculatePower() * Fuels.Gas;
        }

        public override double CalculateCo2()
        {
            return 0.3 * Fuels.Co2;
        }
    }
}