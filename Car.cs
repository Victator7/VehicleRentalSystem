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
    }
}
