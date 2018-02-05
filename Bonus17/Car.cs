namespace Bonus17
{
    internal class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }

        public Car()
        {
            this.make = "test";
            this.model = "test";
            this.year = 2000;
            this.price = 20;
        }

        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public override string ToString()
        {
            string response = string.Format("\n\n Make: {0}\n Model: {1}\n Year: {2}\n Price: ${3}", make, model, year, price);
            return response;
        }
    }

    internal class UsedCar : Car
    {
        public double mileage{ get; set; }

        public UsedCar(string make, string model, int year, double price, double mileage)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.mileage = mileage;
        }

        public override string ToString()
        {
            string response = string.Format("\n\n Make: {0}\n Model: {1}\n Year: {2}\n Price: ${3}\n Mileage: {4}", make, model, year, price, mileage);
            return response;
        }
    }
}