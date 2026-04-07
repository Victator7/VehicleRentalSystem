namespace VehicleRentalSystem
{
    public class Motorcycle : Vehicle
    {
        private int discountThreshold;
        private double discountRate;

        public Motorcycle(string reg, string model, double rate, int threshold, double disc)
            : base(reg, model, rate) // calls Vehicle's constructor
        {
            discountThreshold = threshold;
            discountRate = disc;
        }

        //Overriden method for calculationg rental costs for bikes specifically
        public override double CalculateRentalCost(int duration)
        {
            double cost = BaseRate * duration;
            if (duration > discountThreshold)
                cost -= cost * discountRate;  // apply discount, but only under the right conditions
            return cost;
        }
        //Overrides the overloaded method to display bike-specific info
        public override void DisplayInfo(string format)
        {

            Console.WriteLine($"Registration: {RegistrationNumber} | Model: {Model} | Base Rate: R{BaseRate} | Discount Rate: {discountRate * 100}%");
        }
    }
}
