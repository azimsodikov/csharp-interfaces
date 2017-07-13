using System;

public interface ILandVehicle
{
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    double MaxLandSpeed { get; set; }
    void Start();
    void Stop();
    void Drive();
}

public class Motorcycle : ILandVehicle
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 2;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }
    public void Start()
    {
        Console.WriteLine("The motorcycle started");
    }

    public void Stop()
    {
        Console.WriteLine("The motorcycle stopped");
    }
}
public class Bugghatti : ILandVehicle
{
    public int Wheels { get; set; } = 4;
    public int Doors { get; set; } = 4;
    public int PassengerCapacity { get; set; } = 5;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
        Console.WriteLine("The Bugghatti screams down the highway");
    }
    public void Start()
    {
        Console.WriteLine("The Bugghatti started");
    }

    public void Stop()
    {
        Console.WriteLine("The Bugghatti stopped");
    }
}
public class Lamborghini : ILandVehicle
{
    public int Wheels { get; set; } = 4;
    public int Doors { get; set; } = 2;
    public int PassengerCapacity { get; set; } = 2;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 5.3;
    public double MaxLandSpeed { get; set; } = 300;

    public void Drive()
    {
        Console.WriteLine("The Lamborghini screams down the highway");
    }
    public void Start()
    {
        Console.WriteLine("The Lamborghini started");
    }

    public void Stop()
    {
        Console.WriteLine("The Lamborghini stopped");
    }
}