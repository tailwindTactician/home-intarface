Car car = new Car(0);             
Console.WriteLine("How many liters to refuel?");
int liters = Convert.ToInt32(Console.ReadLine()); 
car.Refuel(liters);                 
car.Drive();                        
