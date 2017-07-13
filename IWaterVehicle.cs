using System;

public interface IWaterVehicle
{
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    double MaxWaterSpeed { get; set; }
    void Start();
    void Stop();
    void Swim();
}

public class JetSki : IWaterVehicle
{
    public int PassengerCapacity { get; set; } = 1;
    public string TransmissionType { get; set; } = "Automatic";
    public double EngineVolume { get; set; } = 1.1;
    public double MaxWaterSpeed { get; set; } = 30;
    public void Swim()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }
    public void Start()
    {
       Console.WriteLine("The jetski started");
    }

    public void Stop()
    {
        Console.WriteLine("The jetski stopped");
    }
}
public class Submarine : IWaterVehicle
{
    public int PassengerCapacity { get; set; } = 100;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 5.0;
    public double MaxWaterSpeed { get; set; } = 25;
    public void Swim()
    {
        Console.WriteLine("The Submarine zips through the waves with the greatest of ease");
    }
    public void Start()
    {
       Console.WriteLine("The Submarine started");
    }

    public void Stop()
    {
        Console.WriteLine("The Submarine stopped");
    }
}
public class Yacht : IWaterVehicle
{
    public int PassengerCapacity { get; set; } = 50;
    public string TransmissionType { get; set; } = "Automatic";
    public double EngineVolume { get; set; } = 3.0;
    public double MaxWaterSpeed { get; set; } = 60;
    public void Swim()
    {
        Console.WriteLine("The Yacht zips through the waves with the greatest of ease");
    }
    public void Start()
    {
       Console.WriteLine("The Yacht started");
    }

    public void Stop()
    {
        Console.WriteLine("The Yacht stopped");
    }
}

