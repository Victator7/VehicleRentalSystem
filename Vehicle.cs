namespace VehicleRentalSystem
{
    public class Vehicle
    {
        private string registrationNumber;
        private string model;
        private double baseRate;

        public Vehicle(string regNum, string model, double bRate)
        {
            this.RegistrationNumber = regNum;
            this.Model = model;
            this.BaseRate = bRate;
        }

        public string RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }
        public string Model { get => model; set => model = value; }
        public double BaseRate { get => baseRate; set => baseRate = value; }

        //Calculates the rental cost based on the duration rented
        public virtual double CalculateRentalCost(int duration)
        {
            return baseRate * duration;
        }

        //Displays information about the vehicles
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Reg: {registrationNumber} | Model: {model}");
        }

        //Displays more information. User simple inputs a string (like "full" or "detailed")
        public virtual void DisplayInfo(string format)
        {
            Console.WriteLine($"Registration: {RegistrationNumber} | Model: {Model} | Base Rate: R{BaseRate}");
        }
    }
}


