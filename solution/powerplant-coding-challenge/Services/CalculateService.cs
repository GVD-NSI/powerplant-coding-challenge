using PowerPlantCodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PowerPlantCodingChallenge.Services
{
    public class CalculateService
    {
        public static readonly IReadOnlyDictionary<FuelType, Type> Mapping = new Dictionary<FuelType, Type>
        {
            { FuelType.GasFired , typeof(GasFired)},
            { FuelType.Turbojet , typeof(Turbojet)},
            { FuelType.WindTurbine , typeof(WindTurbine)}
        };
        public static List<ProductionPlan> Calculate(PayLoad payLoad)
        {
            var engines = payLoad.PowerPlants.Select(e =>
            {
                var fuelEngine = Mapping[e.Type].CreateInstance<FuelEngineAbstract>();
                fuelEngine.Name = e.Name;
                fuelEngine.Fuels = payLoad.Fuels;
                fuelEngine.PowerPlant = e;
                return fuelEngine;
            }).ToArray();

            double sum = 0;
            var list = engines
                .OrderBy(e => e.CalculatePrice() + e.CalculateCo2()).ToList()
                .TakeWhile(e =>
                {
                    var temp = sum; 
                    sum += e.CalculatePower(); 
                    return temp <= payLoad.Load;
                })
                .Select(e => new ProductionPlan
                {
                    Name = e.Name,
                    Power = e.CalculatePower()
                }).ToList();

            return list;
        }
    }
}
