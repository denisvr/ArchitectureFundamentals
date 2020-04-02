namespace OOP
{
    public class CoffeeMachine : HouseholdAppliance
    {
        public CoffeeMachine(string nome, int voltagem)
             : base(nome, voltagem) { }

        public CoffeeMachine()
            : base("Default", 220) { }

        private static void HeatWater() { }

        private static void GrindGrain() { }

        public void PrepareCoffee()
        {
            Test();
            HeatWater();
            GrindGrain();
            // ETC...
        }
        //This method can be override because was created as "Virtual"
        public override void Test()
        {
            // Coffee Machine Test
        }

        public override void TurnOn()
        {
            // Check water
        }

        public override void TurnOff()
        {
            // Coll Heater
        }
    }
}
