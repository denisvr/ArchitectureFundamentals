namespace OOP.ClassVersusObject
{
    //Class Definition
    public class House
    {
        public int Size { get; set; }
        public int NumberFloors { get; set; }
        public decimal Value { get; set; }
        public int Residents { get; set; }
    }
    public class Object
    {
        public Object()
        {
            // Object Definition
            var house = new House
            {
                Size = 100,
                NumberFloors = 2,
                Value = 100000,
                Residents = 3
            };
        }
    }
}
