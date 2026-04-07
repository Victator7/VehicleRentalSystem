namespace VehicleRentalSystem
{
    public class Car : Vehicle
    {
        private double insuranceFee;

        public Car(string reg, string model, double rate, double fee)
            : base(reg, model, rate)  // calls Vehicle's constructor
        {
            this.insuranceFee = fee;
        }

        //Overriden method for calculationg rental costs for cars specifically
        public override double CalculateRentalCost(int duration)
        {
            return (BaseRate * duration) + insuranceFee;
        }

        //Overrides the overloaded method to display car-specific info
        public override void DisplayInfo(string format)
        {
            Console.WriteLine($"Registration: {RegistrationNumber} | Model: {Model} | Base Rate: R{BaseRate} | Insurance Fee: R{insuranceFee}");
        }
    }
}
