using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly
        List<IFlyVehicle> flyingVehicles = new List<IFlyVehicle>()
        {
            new Cessna()
        };
        // With a single `foreach`, have each vehicle Fly()
        foreach (var item in flyingVehicles)
        {
            item.Fly();
        }
        // Build a collection of all vehicles that operate on roads
        List<ILandVehicle> groundVehicles = new List<ILandVehicle>()
        {
            new Lamborghini(),
            new Bugghatti()
        };
        // With a single `foreach`, have each road vehicle Drive()
        foreach (var item in groundVehicles)
        {
            item.Drive();
            item.Start();
        }
        // Build a collection of all vehicles that operate on water
        List<IWaterVehicle> waterVehicles = new List<IWaterVehicle>()
        {
            new Yacht(),
            new Submarine()
        };
        // With a single `foreach`, have each watezr vehicle Drive()
        foreach (var item in waterVehicles)
        {
            item.Swim();
            item.Start();
        }
    }

}