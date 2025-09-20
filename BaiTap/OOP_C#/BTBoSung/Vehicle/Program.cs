namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = new Car(0);
            int fuel;
            Console.WriteLine("Nhap so xang muon do vao: ");
            fuel = int.Parse(Console.ReadLine());
            car.Refuel(fuel);
            car.Drive();
        }
    }
}