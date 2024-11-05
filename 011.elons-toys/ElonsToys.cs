using System;

public class RemoteControlCar
{
     private int distanceDriven;
     private int batteryPercentage;

    // Constructor
     public RemoteControlCar()
    {
        distanceDriven = 0;
        batteryPercentage = 100;
    }

    // Static method to buy a new car
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    // Method to display the distance driven
    public string DistanceDisplay()
    {
        return $"Driven {distanceDriven} meters";
    }

    // Method to display the battery percentage
    public string BatteryDisplay()
    {
        if (batteryPercentage > 0)
        {
            return $"Battery at {batteryPercentage}%";
        }
        else
        {
            return "Battery empty";
        }
    }

    // Method to drive the car
    public void Drive()
    {
        if (batteryPercentage > 0)
        {
            distanceDriven += 20;
            batteryPercentage -= 1;
        }
    }
}