using System;

public interface IFlyVehicle
{
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    bool Winged { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    double MaxAirSpeed { get; set; }
    void Start();
    void Stop();
    void Fly();
}
public class Cessna : IVehicle, IFlyVehicle, IWaterVehicle
{
  public int Doors { get; set; } = 3;
  public int PassengerCapacity { get; set; } = 113;
  public bool Winged { get; set; } = true;
  public string TransmissionType { get; set; } = "None";
  public double EngineVolume { get; set; } = 31.1;
  public double MaxWaterSpeed { get; set; }
  public double MaxAirSpeed { get; set; } = 309.0;

  public void Swim()
  {
    Console.WriteLine("The Cessna starts to swim on the water");
  }
  public void Drive()
  {
    Console.WriteLine("The Cessna was going the water");
  }
  public void Fly()
  {
    Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
  }

  public void Start()
  {
    Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
  }

  public void Stop()
  {
    Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
  }
}
