using System;

namespace PowerPlantCodingChallenge.Services
{
    public class Turbojet : FuelEngineAbstract
    {
        public override double CalculatePower()
        {
            return Math.Round(PowerPlant.Efficiency * PowerPlant.PMax,1);
        }

        public override double CalculatePrice()
        {
            return CalculatePower() * Fuels.Kerosine;
        }

        public override double CalculateCo2()
        {
            return 0;
        }
    }
}