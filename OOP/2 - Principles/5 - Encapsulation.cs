namespace OOP
{
    public class CoffeeAutomation
    {
        public void ServeCoffee()
        {
            var espresso = new CoffeeMachine();
            espresso.TurnOn();
            espresso.PrepareCoffee();
            espresso.TurnOff();
        }
    }
}
