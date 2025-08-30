public class Car : IVehicle
{
    private int Fuel;
    public Car(int Startfuel)
    {
        if (Startfuel < 0) Startfuel = 0;
        Fuel = Startfuel;
    }
    public void Drive()
    {
        if (Fuel > 0)
            System.Console.WriteLine("Driving");
        else
        {
            System.Console.WriteLine("Can't Driving");
        }
    }
    public bool Refuel(int benzin)
    {
        Fuel += benzin;
        return true;
    }
}