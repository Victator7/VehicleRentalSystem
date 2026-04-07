using VehicleRentalSystem;

//(Registration: "ABC123", Model: "Toyota Corolla", Base Rate: 50, Insurance Fee: 20)
Car car = new Car("ABC123", "Toyota Corolla", 50, 20);
//(Registration: "XYZ789", Model: "Honda CB500", Base Rate: 15, Discount Threshold: 5 hours, Discount Rate: 0.10)
Motorcycle bike = new Motorcycle("XYZ789", "Honda CB500", 15, 5, 0.10);

Console.WriteLine("Rental cost: R" + car.CalculateRentalCost(7 * 24));   // 7 days ( 7 * 24 hours)
Console.WriteLine("Rental cost: R" + bike.CalculateRentalCost(8));  // 8 hours with the discount applying after 5 hours

car.DisplayInfo();
car.DisplayInfo("Full");
bike.DisplayInfo();
bike.DisplayInfo("Full");